using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.AdoNet
{
    public class AdMusteriDal:IMusteriDal
    {
        public List<Musteri> MusteriListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM siparisTakip.Musteriler", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Musteri> Musteriler = new List<Musteri>();
                    Musteriler.Add(new Musteri { MusteriId = 0, MusteriAd = "Müşteri Seç.." });
                    while (dataReader.Read())
                    {
                        Musteriler.Add(
                        new Musteri
                        {
                            MusteriId = Convert.ToInt32(dataReader["Id"]),
                            MusteriAd = dataReader["MusteriAd"].ToString(),
                            MusteriTip = dataReader["MusteriTip"].ToString(),
                            Ulke = dataReader["Ulke"].ToString(),
                            Sehir = dataReader["Sehir"].ToString()
                           

                        });
                    }
                    return Musteriler;
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
