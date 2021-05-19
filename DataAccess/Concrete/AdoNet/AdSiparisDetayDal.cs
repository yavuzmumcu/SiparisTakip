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
    public class AdSiparisDetayDal : ISiparisDetayDal
    {
        public int Ekle(SiparisDetay siparisDetay)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SiparisTakip.SiparisDetaylari (siparisId,UrunId,KaliteId,RenkId,Logo,Adet,Aciklama,YuklemeTipId,PaletId,Kutu,kalanAdet)" +
                "VALUES(@siparisId,@UrunId,@KaliteId,@RenkId,@Logo,@Adet,@Aciklama,@YuklemeTipId,@PaletId,@kutu,@kalanAdet) SELECT SCOPE_IDENTITY()", Baglanti.sqlCon);

            command.Parameters.AddWithValue("@siparisId", siparisDetay.SiparisId);
            command.Parameters.AddWithValue("@UrunId", siparisDetay.UrunId);
            command.Parameters.AddWithValue("@KaliteId", siparisDetay.KaliteId);
            command.Parameters.AddWithValue("@RenkId", siparisDetay.RenkId);
            command.Parameters.AddWithValue("@Logo", siparisDetay.Logo);
            command.Parameters.AddWithValue("@Adet", siparisDetay.Adet);
            command.Parameters.AddWithValue("@Aciklama", siparisDetay.Aciklama);
            command.Parameters.AddWithValue("@YuklemeTipId", siparisDetay.YuklemeTipId);
            command.Parameters.AddWithValue("@PaletId", siparisDetay.PaletId);
            command.Parameters.AddWithValue("@Kutu", siparisDetay.Kutu);
            command.Parameters.AddWithValue("@KalanAdet", siparisDetay.Adet);
            Baglanti.OpenConnection();

            int result = Convert.ToInt32(command.ExecuteScalar());

            Baglanti.sqlCon.Close();

            return result;
        }

        public int Sil(SiparisDetay siparisDetay)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM SiparisTakip.SiparisDetaylari WHERE Id=@siparisDetayId ", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@siparisDetayId", siparisDetay.SiparisDetayId);
                Baglanti.OpenConnection();

                int result = command.ExecuteNonQuery();

                Baglanti.sqlCon.Close();

                return result;
            }

        }

        public List<SiparisDetayDeger> SiparisDetayDegerleriListele(int siparisId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.View_SiparisDetayDegerleri WHERE siparisId=@siparisId ", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@siparisId", siparisId);
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<SiparisDetayDeger> SiparisDetayDegerleri = new List<SiparisDetayDeger>();
                    while (dataReader.Read())
                    {
                        SiparisDetayDegerleri.Add(new SiparisDetayDeger
                        {
                            SiparisDetayId = Convert.ToInt32(dataReader["Id"]),
                            UrunKodu = dataReader["stokkod"].ToString(),
                            Kalite = dataReader["tanim"].ToString(),
                            RenkAd = dataReader["renkad"].ToString(),
                            Adet = Convert.ToInt32(dataReader["Adet"]),
                            YuklemeTip = dataReader["YuklemeTip"].ToString(),
                            Palet = dataReader["palet"].ToString(),
                            KalanAdet= Convert.ToInt32(dataReader["kalanAdet"]),

                        });
                    }
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return SiparisDetayDegerleri;
                }
                else
                {
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return null;
                }
            }
        }

        public SiparisDetay SiparisDetay(int siparisId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.SiparisDetaylari WHERE Id=@siparisId", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@siparisId", siparisId);

                Baglanti.OpenConnection();

                SqlDataReader dataReader = command.ExecuteReader();


                if (dataReader.HasRows)
                {
                    SiparisDetay SiparisDetay = new SiparisDetay();
                    while (dataReader.Read())
                    {
                        SiparisDetay.SiparisId = siparisId;
                        SiparisDetay.UrunId = Convert.ToInt32(dataReader["UrunId"]);
                        SiparisDetay.KaliteId = Convert.ToInt32(dataReader["KaliteId"]);
                        SiparisDetay.RenkId = Convert.ToInt32(dataReader["RenkId"]);
                        SiparisDetay.Logo = dataReader["Logo"].ToString();
                        SiparisDetay.Adet = Convert.ToInt32(dataReader["Adet"]);
                        SiparisDetay.islemTarih = Convert.ToDateTime(dataReader["islemTarih"]);
                        SiparisDetay.Aciklama = dataReader["Aciklama"].ToString();
                        SiparisDetay.YuklemeTipId = Convert.ToInt32(dataReader["YuklemeTipId"]);
                        SiparisDetay.PaletId = Convert.ToInt32(dataReader["PaletId"]);
                        SiparisDetay.Kutu= dataReader["Kutu"].ToString();
                    }
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return SiparisDetay;
                }
                else
                {
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return null;
                }


            }
        }

        public int Guncelle(SiparisDetay siparisDetay)
        {
            using (SqlCommand command = new SqlCommand("UPDATE SiparisTakip.siparisDetaylari SET " +
                "urunId=@urunId,kaliteId=@kaliteId,renkId=@renkId,Logo=@Logo,Adet=@adet,aciklama=@aciklama,yuklemeTipID=@yuklemeTipID,paletId=@paletId,kutu=@kutu,kalanAdet=@kalanAdet " +
                "WHERE Id=@Id",
                Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@urunId", siparisDetay.UrunId);
                command.Parameters.AddWithValue("@kaliteId", siparisDetay.KaliteId);
                command.Parameters.AddWithValue("@renkId", siparisDetay.RenkId);
                command.Parameters.AddWithValue("@Logo", siparisDetay.Logo);
                command.Parameters.AddWithValue("@Adet", siparisDetay.Adet);
                command.Parameters.AddWithValue("@aciklama", siparisDetay.Aciklama);
                command.Parameters.AddWithValue("@yuklemeTipID", siparisDetay.YuklemeTipId);
                command.Parameters.AddWithValue("@paletId", siparisDetay.PaletId);
                command.Parameters.AddWithValue("@kutu", siparisDetay.Kutu);
                command.Parameters.AddWithValue("@kalanAdet", siparisDetay.Adet);

                command.Parameters.AddWithValue("@Id", siparisDetay.SiparisDetayId);

                Baglanti.OpenConnection();

                int sonuc = command.ExecuteNonQuery();

                Baglanti.sqlCon.Close();

                return sonuc;
            }
        }
    }
}
