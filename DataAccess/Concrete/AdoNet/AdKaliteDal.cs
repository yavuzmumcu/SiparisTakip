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
    public class AdKaliteDal:IKaliteDal
    {
        public List<Kalite> KaliteListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM kalite_liste", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Kalite> Kaliteler = new List<Kalite>();
                    Kaliteler.Add(new Kalite { KaliteId = 0, KaliteAd = "Kalite Seç.." });
                    while (dataReader.Read())
                    {
                        Kaliteler.Add(
                        new Kalite
                        {
                            KaliteId = Convert.ToInt32(dataReader["kimlik"]),
                            KaliteAd = dataReader["tanim"].ToString(),
                            
                        });
                    }
                    return Kaliteler;
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
