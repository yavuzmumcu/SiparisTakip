using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.AdoNet
{
    public class AdYuklemePlaniDetayDal : IYuklemePlaniDetayDal
    {
        public int Ekle(YuklemePlaniDetay yuklemePlaniDetay)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SiparisTakip.YuklemePlaniDetaylari (YuklemePlaniId,SiparisDetayId,Adet) " +
                "VALUES(@YuklemePlaniId,@SiparisDetayId,@Adet)", Baglanti.sqlCon);

            command.Parameters.AddWithValue("@YuklemePlaniId", yuklemePlaniDetay.YuklemePlaniId);

            command.Parameters.AddWithValue("@SiparisDetayId", yuklemePlaniDetay.SiparisDetayId);

            command.Parameters.AddWithValue("@Adet", yuklemePlaniDetay.Adet);


            Baglanti.OpenConnection();

            int result = command.ExecuteNonQuery();

            Baglanti.sqlCon.Close();

            return result; ;
        }

        public List<YuklemePlaniDetayListe> YuklemePlaniDetayListele(int yuklemePlaniId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.View_YuklemePlaniListe WHERE Id=@yuklemePlaniId", Baglanti.sqlCon);
            try
            {
                command.Parameters.AddWithValue("@yuklemePlaniId", yuklemePlaniId);

                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<YuklemePlaniDetayListe> yuklemePlaniDetaylari = new List<YuklemePlaniDetayListe>();
                    
                    while (dataReader.Read())
                    {
                        yuklemePlaniDetaylari.Add(
                        new YuklemePlaniDetayListe
                        {
                            DetayId= Convert.ToInt32(dataReader["detayId"]),
                            MusteriAd = dataReader["MusteriAd"].ToString(),
                           
                            StokKod = dataReader["stokkod"].ToString(),
                            Adet = Convert.ToInt32(dataReader["adet"]),
                            YuklemePlaniAd = dataReader["YuklemePlaniAd"].ToString(),
                            YuklenecekAdet = Convert.ToInt32(dataReader["yuklenecekAdet"]),
                            Id= yuklemePlaniId,
                            

                        });
                    }
                    return yuklemePlaniDetaylari;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
                return null;
            }
            finally
            {
                Baglanti.sqlCon.Close();
            }
        }

        public int Sil(YuklemePlaniDetay yuklemePlaniDetay)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM SiparisTakip.YuklemePlaniDetaylari WHERE Id=@yuklemePlaniDetayId ", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@yuklemePlaniDetayId", yuklemePlaniDetay.Id);
                Baglanti.OpenConnection();

                int result = command.ExecuteNonQuery();

                Baglanti.sqlCon.Close();

                return result;
            }
        }

        public List<YuklemePlaniDetay> YuklemePlaniDetayListeleBySiparisId(int siparisDetayId)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.YuklemePlaniDetaylari WHERE siparisDetayId=@siparisDetayId", Baglanti.sqlCon);
            try
            {
                command.Parameters.AddWithValue("@siparisDetayId", siparisDetayId);

                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    var yuklemePlaniDetaylari = new List<YuklemePlaniDetay>();

                    while (dataReader.Read())
                    {
                        yuklemePlaniDetaylari.Add(
                        new YuklemePlaniDetay
                        {
                           Id=Convert.ToInt32(dataReader["Id"])


                        }) ;
                    }
                    return yuklemePlaniDetaylari;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {
              
                return null;
            }
            finally
            {
                Baglanti.sqlCon.Close();
            }
        }
    }
}
