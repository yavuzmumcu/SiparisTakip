using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOtherEntitiesService
    {
        List<Palet> PaletListele();
        List<SevkArac> SevkAracListele();
        List<YuklemeTip> YuklemeTipListele();
        YuklemeTip Kutu(int yuklemeTipId);
    }
}
