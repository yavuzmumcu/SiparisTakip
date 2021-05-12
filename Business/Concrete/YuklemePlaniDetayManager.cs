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
    public class YuklemePlaniDetayManager : IYuklemePlaniDetayService
    {
        public YuklemePlaniDetayManager(IYuklemePlaniDetayDal yuklemePlaniDetayDal)
        {
            _yuklemePlaniDetayDal = yuklemePlaniDetayDal;
        }
        IYuklemePlaniDetayDal _yuklemePlaniDetayDal;
        public int Ekle(YuklemePlaniDetay yuklemePlaniDetay)
        {
           return _yuklemePlaniDetayDal.Ekle(yuklemePlaniDetay);
        }

        public List<YuklemePlaniDetayListe> YuklemePlaniDetayListele(int yuklemePlaniId)
        {
            return _yuklemePlaniDetayDal.YuklemePlaniDetayListele(yuklemePlaniId);
        }
    }
}
