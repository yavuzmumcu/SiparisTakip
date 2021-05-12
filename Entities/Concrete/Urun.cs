using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Urun : IEntity
    {
        public int UrunId { get; set; }
        public string KalipKod { get; set; }
        public string UretimKod { get; set; }
        public string StokKod { get; set; }
        public string Camur { get; set; }
        public int KaliteBarkodNo { get; set; }
        public string Aciklama { get; set; }
    }
}
