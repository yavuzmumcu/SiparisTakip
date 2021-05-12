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
    public class AdOtherEntitiesDal: IOtherEntitiesDal
    {
        public List<Palet> PaletListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.Paletler", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<Palet> Paletler = new List<Palet>();
                    Paletler.Add(new Palet { PaletId = 0, PaletAd = "Palet Seç.." });
                    while (dataReader.Read())
                    {
                        Paletler.Add(
                        new Palet
                        {
                            PaletId = Convert.ToInt32(dataReader["Id"]),
                            PaletAd = dataReader["palet"].ToString(),

                        });
                    }
                    return Paletler;
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

        public List<SevkArac> SevkAracListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.SevkAraclari", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<SevkArac> SevkAraclari = new List<SevkArac>();
                    SevkAraclari.Add(new SevkArac { SevkAracId = 0, SevkAracAd = "Sevk Aracı Seç.." });
                    while (dataReader.Read())
                    {
                        SevkAraclari.Add(
                        new SevkArac
                        {
                            SevkAracId = Convert.ToInt32(dataReader["Id"]),
                            SevkAracAd = dataReader["sevkAraci"].ToString(),

                        });
                    }
                    return SevkAraclari;
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

        public List<YuklemeTip> YuklemeTipListele()
        {
            SqlCommand command = new SqlCommand("SELECT * FROM SiparisTakip.YuklemeTipleri", Baglanti.sqlCon);
            try
            {
                Baglanti.OpenConnection();
                SqlDataReader dataReader = command.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<YuklemeTip> YuklemeTipleri = new List<YuklemeTip>();
                    YuklemeTipleri.Add(new YuklemeTip { YuklemeTipId = 0, YuklemeTipAd = "Yukleme Şekli Seç.." });
                    while (dataReader.Read())
                    {
                        YuklemeTipleri.Add(
                        new YuklemeTip
                        {
                            YuklemeTipId = Convert.ToInt32(dataReader["Id"]),
                            YuklemeTipAd = dataReader["YuklemeTip"].ToString(),

                        });
                    }
                    return YuklemeTipleri;
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

        public YuklemeTip Kutu(int yuklemeTipId)
        {
            SqlCommand command = new SqlCommand("SELECT kutu FROM SiparisTakip.YuklemeTipleri WHERE Id=@yuklemeTipId", Baglanti.sqlCon);
            command.Parameters.AddWithValue("@yuklemeTipId", yuklemeTipId);

            Baglanti.OpenConnection();

            SqlDataReader dataReader = command.ExecuteReader();


            if (dataReader.HasRows)
            {
                YuklemeTip yuklemeTip = new YuklemeTip();
                while (dataReader.Read())
                {
                    yuklemeTip.Kutu = Convert.ToInt32(dataReader["Kutu"]);
                }
                Baglanti.sqlCon.Close();
                dataReader.Close();
                return yuklemeTip;
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
