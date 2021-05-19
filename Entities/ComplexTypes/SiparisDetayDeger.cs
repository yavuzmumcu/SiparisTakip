using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ComplexTypes
{
    public class SiparisDetayDeger
    {
        public int SiparisDetayId { get; set; }
        public string UrunKodu { get; set; }
        public string Kalite { get; set; }
        public string RenkAd { get; set; }
        public int Adet { get; set; }
        public string YuklemeTip { get; set; }
        public string Palet { get; set; }
        public int KalanAdet { get; set; }

    }
}
