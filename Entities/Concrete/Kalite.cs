

using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kalite:IEntity
    {
        public int KaliteId { get; set; }
        public string KaliteAd { get; set; }
        public string KaliteKod { get; set; }
    }
}
