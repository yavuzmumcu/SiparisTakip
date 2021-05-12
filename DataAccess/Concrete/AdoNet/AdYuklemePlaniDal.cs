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
    public class AdYuklemePlaniDal : IYuklemePlaniDal
    {
        public int Ekle(YuklemePlani yuklemePlani)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SiparisTakip.YuklemePlanlari (YuklemePlaniAd,KullaniciId) VALUES(@YuklemePlaniAd,@KullaniciId) SELECT SCOPE_IDENTITY()", Baglanti.sqlCon);

            command.Parameters.AddWithValue("@YuklemePlaniAd", yuklemePlani.Ad);
           
            command.Parameters.AddWithValue("@KullaniciId", yuklemePlani.KullaniciId);
            

            Baglanti.OpenConnection();

            int result = Convert.ToInt32(command.ExecuteScalar());

            Baglanti.sqlCon.Close();

            return result; ;
        }

        public YuklemePlaniDeger yuklemePlaniDegerleri(int yuklemePlaniId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.View_YuklemePlaniDegerleri WHERE Id=@yuklemePlaniId", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@yuklemePlaniId", yuklemePlaniId);

                Baglanti.OpenConnection();

                SqlDataReader dataReader = command.ExecuteReader();


                if (dataReader.HasRows)
                {
                    YuklemePlaniDeger yuklemePlaniDeger = new YuklemePlaniDeger();
                    while (dataReader.Read())
                    {
                        yuklemePlaniDeger.SevkAdres = dataReader["sevkAdres"].ToString(); ;
                        yuklemePlaniDeger.SevkArac = dataReader["Sevkaraci"].ToString();
                        yuklemePlaniDeger.YuklemePlaniAd = dataReader["YuklemePlaniAd"].ToString();
                        
                    }
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return yuklemePlaniDeger;
                }
                else
                {
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return null;
                }


            }
        }

        public List<YuklemePlaniDeger> YuklemePlanlariListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.View_YuklemePlaniDegerleri", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<YuklemePlaniDeger> yuklemePlanlari = new List<YuklemePlaniDeger>();

                    while (dataReader.Read())
                    {
                        yuklemePlanlari.Add(
                        new YuklemePlaniDeger
                        {
                            YuklemePlaniId= Convert.ToInt32(dataReader["Id"]),
                            YuklemePlaniAd = dataReader["YuklemePlaniAd"].ToString(),
                            SevkAdres = dataReader["sevkadres"].ToString(),
                            SevkArac = dataReader["sevkAraci"].ToString(),
                            islemTarih = Convert.ToDateTime(dataReader["islemTarih"]),

                        });
                    }
                    return yuklemePlanlari;
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
