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
    public class AdRenkDal:IRenkDal
    {
        public List<Renk> RenkListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Renk_liste", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Renk> Renkler = new List<Renk>();
                    Renkler.Add(new Renk { RenkId = 0, RenkAd = "Renk Seç.." });
                    while (dataReader.Read())
                    {
                        Renkler.Add(
                        new Renk
                        {
                            RenkId = Convert.ToInt32(dataReader["kimlik"]),
                            RenkAd = dataReader["renkad"].ToString(),
                           


                        });
                    }
                    return Renkler;
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
