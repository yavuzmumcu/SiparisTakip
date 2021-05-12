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
    public class OtherEntitiesManager : IOtherEntitiesService
    {
        public OtherEntitiesManager(IOtherEntitiesDal otherEntitiesDal)
        {
            _otherEntitiesDal = otherEntitiesDal;
        }
        IOtherEntitiesDal _otherEntitiesDal;
        public List<Palet> PaletListele()
        {
            return _otherEntitiesDal.PaletListele();
        }

        public List<SevkArac> SevkAracListele()
        {
            return _otherEntitiesDal.SevkAracListele();
        }

        public List<YuklemeTip> YuklemeTipListele()
        {
            return _otherEntitiesDal.YuklemeTipListele();
        }

        public YuklemeTip Kutu(int yuklemeTipId)
        {
            return _otherEntitiesDal.Kutu(yuklemeTipId);
        }
    }
}
