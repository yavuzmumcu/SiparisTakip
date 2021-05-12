using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNet;
using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{

    public class SiparisManager : ISiparisService
    {
        public SiparisManager(ISiparisDal siparisDal)
        {
            _siparisDal = siparisDal;
        }
        ISiparisDal _siparisDal;

        public int Ekle(Siparis siparis)
        {
            if (siparis.MusteriId == 0)
            {
                return 0;
            }
            else
            {
                int result = _siparisDal.Ekle(siparis);
                return result;
            }
        }

        public SiparisDeger siparisDegerleriniGetir(int siparisId)
        {
            return _siparisDal.siparisDegerleriniGetir(siparisId);
        }

        public List<Siparisler> SiparisleriListele()
        {
            return _siparisDal.SiparisleriListele();
        }

        public int Sil(Siparis siparis)
        {
            return _siparisDal.Sil(siparis);
        }
    }
}
