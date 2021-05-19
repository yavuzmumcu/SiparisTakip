using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ComplexTypes
{
    public class YuklemePlaniDetayListe
    {
        public int DetayId { get; set; }
        public int Id { get; set; }
        public string MusteriAd { get; set; }
        public string StokKod { get; set; }
        public int Adet { get; set; }
        public string YuklemePlaniAd { get; set; }
        public int YuklenecekAdet { get; set; }
    }
}
