using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Musteri : IEntity
    {
        public int MusteriId { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriTip { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
    }
}
