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
    public class RenkManager : IRenkService
    {
        public RenkManager(IRenkDal renkDal)
        {
            _renkDal = renkDal;
        }
        IRenkDal _renkDal;

        public List<Renk> RenkListele()
        {
           
            return _renkDal.RenkListele();
        }
    }
}
