using Business.Abstract;
using DataAccess.Abstract;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SiparisDetayManager:ISiparisDetayService
    {
        public SiparisDetayManager(ISiparisDetayDal siparisDetayDal,IYuklemePlaniDetayService yuklemePlaniDetayService)
        {
            _siparisDetayDal = siparisDetayDal;
            _yuklemePlaniDetayService = yuklemePlaniDetayService;
        }
        ISiparisDetayDal _siparisDetayDal;
        IYuklemePlaniDetayService _yuklemePlaniDetayService;

        public int Ekle(SiparisDetay siparisDetay)
        {
            if (siparisDetay.UrunId==0 || siparisDetay.KaliteId == 0 || siparisDetay.RenkId == 0 || siparisDetay.PaletId == 0 || siparisDetay.YuklemeTipId == 0 || siparisDetay.Adet == 0 )                 
            {
                return 0;
            }
            else
            {
                return _siparisDetayDal.Ekle(siparisDetay);
            }           
        }

        public List<SiparisDetayDeger> SiparisDetayDegerleriListele(int siparisId)
        {
            return _siparisDetayDal.SiparisDetayDegerleriListele(siparisId);
        }

        public int Sil(SiparisDetay siparisDetay)
        {
            if (_yuklemePlaniDetayService.YuklemePlaniDetayListeleBySiparisId(siparisDetay.SiparisDetayId) != null)
            {
                return 0;
            }
            else
            {
                return _siparisDetayDal.Sil(siparisDetay);
            }
        }

        public SiparisDetay SiparisDetay(int siparisId)
        {
            return _siparisDetayDal.SiparisDetay(siparisId);
        }

        public int Guncelle(SiparisDetay siparisDetay)
        {
            if (_yuklemePlaniDetayService.YuklemePlaniDetayListeleBySiparisId(siparisDetay.SiparisDetayId) != null)
            {
                return 0;
            }
            else
            {
                return _siparisDetayDal.Guncelle(siparisDetay);
            }
        }
    }
}
 