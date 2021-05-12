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
    public class AdUrunDal:IUrunDal
    {
        public List<Urun> UrunListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM kod_liste", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Urun> Urunler = new List<Urun>();
                    Urunler.Add(new Urun { UrunId = 0, StokKod = "Ürün Kodu Seç.." });
                    while (dataReader.Read())
                    {
                        Urunler.Add(
                        new Urun
                        {
                            UrunId = Convert.ToInt32(dataReader["kimlik"]),
                            StokKod = dataReader["stokkod"].ToString(),
                            
                        });
                    }
                    return Urunler;
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
