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
    public class MusteriManager : IMusteriService
    {
        public MusteriManager(IMusteriDal musteriDal)
        {
            _musteriDal = musteriDal;
        }
        IMusteriDal _musteriDal;
        public List<Musteri> MusteriListele()
        {
            return _musteriDal.MusteriListele();
        }
    }
}
