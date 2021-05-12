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
    public class AdSiparisDal : ISiparisDal
    {
        public int Ekle(Siparis siparis)
        {
            SqlCommand command = new SqlCommand("INSERT INTO SiparisTakip.Siparisler (siparisNo,MusteriId,KullaniciId,SiparisTarih,Aciklama)VALUES(@siparisNo,@MusteriId,@KullaniciId,@SiparisTarih,@Aciklama) SELECT SCOPE_IDENTITY()", Baglanti.sqlCon);

            command.Parameters.AddWithValue("@siparisNo", siparis.SiparisNo);
            command.Parameters.AddWithValue("@MusteriId", siparis.MusteriId);
            command.Parameters.AddWithValue("@KullaniciId", siparis.KullaniciId);
            command.Parameters.AddWithValue("@SiparisTarih", siparis.SiparisTarih);
            command.Parameters.AddWithValue("@Aciklama", siparis.Aciklama);

            Baglanti.OpenConnection();

            int result =Convert.ToInt32(command.ExecuteScalar());

            Baglanti.sqlCon.Close();

            return result;
        }

        public int Sil(Siparis siparis)
        {
            using (SqlCommand command = new SqlCommand("DELETE FROM SiparisTakip.Siparisler WHERE Id=@siparisId ", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@siparisId", siparis.SiparisId);
                Baglanti.OpenConnection();

                int result = command.ExecuteNonQuery();

                Baglanti.sqlCon.Close();

                return result;
            }
        }

        public SiparisDeger siparisDegerleriniGetir(int siparisId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.View_SiparisDegerleri WHERE Id=@siparisId", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@siparisId", siparisId);

                Baglanti.OpenConnection();

                SqlDataReader dataReader = command.ExecuteReader();


                if (dataReader.HasRows)
                {
                    SiparisDeger siparisDeger = new SiparisDeger();
                    while (dataReader.Read())
                    {
                        siparisDeger.SiparisId = siparisId;
                        siparisDeger.SiparisNo = dataReader["SiparisNo"].ToString();
                        siparisDeger.MusteriAd = dataReader["MusteriAd"].ToString();
                        siparisDeger.PersonelAdSoyad = dataReader["PersonelAdSoyad"].ToString();
                        siparisDeger.SiparisTarih =Convert.ToDateTime(dataReader["siparisTarih"]);
                        siparisDeger.islemTarih = Convert.ToDateTime(dataReader["islemTarih"]);
                        siparisDeger.Aciklama = dataReader["aciklama"].ToString();
                        siparisDeger.Pazar = dataReader["pazar"].ToString();
                    }
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return siparisDeger;
                }
                else
                {
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return null;
                }


            }
        }

        public List<Siparisler> SiparisleriListele()
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.View_SiparisDegerleri  ", Baglanti.sqlCon))
            {
               
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Siparisler> Siparisler = new List<Siparisler>();
                    while (dataReader.Read())
                    {
                        Siparisler.Add(new Siparisler
                        {
                            SiparisId = Convert.ToInt32(dataReader["Id"]),
                            MusteriAd = dataReader["MusteriAd"].ToString(),
                            SiparisTarih =Convert.ToDateTime(dataReader["siparisTarih"]),

                        });
                    }
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return Siparisler;
                }
                else
                {
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return null;
                }
            }
        }
    }
}
