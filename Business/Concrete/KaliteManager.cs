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
    public class KaliteManager:IKaliteService
    {
        public KaliteManager(IKaliteDal kaliteDal)
        {
            _kaliteDal = kaliteDal;
        }
        IKaliteDal _kaliteDal;

        public List<Kalite> KaliteListele()
        {
            return _kaliteDal.KaliteListele();
        }
    }
}
