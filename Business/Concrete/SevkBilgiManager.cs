using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class SevkBilgiManager:ISevkBilgiService
    {
        public SevkBilgiManager(ISevkBilgiDal sevkBilgiDal)
        {
            _sevkBilgiDal = sevkBilgiDal;
        }
        ISevkBilgiDal _sevkBilgiDal;

        public int Ekle(SevkBilgi sevkBilgi)
        {
            return _sevkBilgiDal.Ekle(sevkBilgi);
        }

        public int SevkVarMi(int siparisId)
        {
            return _sevkBilgiDal.SevkVarMi(siparisId);
        }

        public SevkBilgi SevkBilgileriGetir(int siparisId)
        {
            return _sevkBilgiDal.SevkBilgileriGetir(siparisId);
        }
    }
}
