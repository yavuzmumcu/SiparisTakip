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
    public class UrunManager : IUrunService
    {
        public UrunManager(IUrunDal urunDal)
        {
            _urunDal = urunDal;
        }
        IUrunDal _urunDal;

        public List<Urun> UrunListele()
        {
            return _urunDal.UrunListele();
        }
    }
}
