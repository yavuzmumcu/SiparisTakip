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
    public class YuklemePlaniManager:IYuklemePlaniService
    {
        public YuklemePlaniManager(IYuklemePlaniDal yuklemePlaniDal)
        {
            _yuklemePlaniDal = yuklemePlaniDal;
        }
        IYuklemePlaniDal _yuklemePlaniDal;

        public int Ekle(YuklemePlani yuklemePlani)
        {
           return _yuklemePlaniDal.Ekle(yuklemePlani);
        }

        public YuklemePlaniDeger yuklemePlaniDegerleri(int yuklemePlaniId)
        {
            return _yuklemePlaniDal.yuklemePlaniDegerleri(yuklemePlaniId);
        }

        public List<YuklemePlaniDeger> YuklemePlanlariListele()
        {
            return _yuklemePlaniDal.YuklemePlanlariListele();
        }
    }
}
