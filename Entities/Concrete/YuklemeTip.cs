using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class YuklemeTip : IEntity
    {
        public int YuklemeTipId { get; set; }
        public string YuklemeTipAd { get; set; }
        public int Kutu { get; set; }
    }
}
