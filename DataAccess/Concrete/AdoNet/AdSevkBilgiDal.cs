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
    public class AdSevkBilgiDal:ISevkBilgiDal
    {
        public int Ekle(SevkBilgi sevkBilgi)
        {
            SqlCommand command = new SqlCommand("INSERT INTO Siparistakip.SevkBilgileri (yuklemePlaniId,sevkAracId,SevkAdres)" +
                "VALUES(@yuklemePlaniId,@sevkAracId,@SevkAdres)", Baglanti.sqlCon);

            command.Parameters.AddWithValue("@yuklemePlaniId", sevkBilgi.SiparisId);
            command.Parameters.AddWithValue("@sevkAracId", sevkBilgi.SevkAracId);
            command.Parameters.AddWithValue("@SevkAdres", sevkBilgi.SevkAdres);
            
            Baglanti.OpenConnection();

            int result = command.ExecuteNonQuery();

            Baglanti.sqlCon.Close();

            return result;
        }

        public SevkBilgi SevkBilgileriGetir(int siparisId)
        {
            using (SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.SevkBilgileri WHERE siparisId=@siparisId", Baglanti.sqlCon))
            {
                command.Parameters.AddWithValue("@siparisId", siparisId);

                Baglanti.OpenConnection();

                SqlDataReader dataReader = command.ExecuteReader();


                if (dataReader.HasRows)
                {
                    SevkBilgi sevkBilgi = new SevkBilgi();
                    while (dataReader.Read())
                    {
                        sevkBilgi.SiparisId = siparisId;
                        sevkBilgi.SevkAracId = Convert.ToInt32(dataReader["SevkAracId"]);
                        sevkBilgi.SevkBilgiId = Convert.ToInt32(dataReader["Id"]);
                        sevkBilgi.SevkAdres = dataReader["SevkAdres"].ToString();
                    }
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return sevkBilgi;
                }
                else
                {
                    Baglanti.sqlCon.Close();
                    dataReader.Close();
                    return null;
                }


            }
        }

        public int SevkVarMi(int siparisId)
        {
            SqlCommand command = new SqlCommand("SELECT COUNT(*) AS Adet FROM SiparisTakip.Sevkbilgileri WHERE siparisId=@siparisId", Baglanti.sqlCon);
            command.Parameters.AddWithValue("@siparisId", siparisId);

            Baglanti.OpenConnection();

            int result =(int)command.ExecuteScalar();

            Baglanti.sqlCon.Close();
            return result;

        }
    }
}
