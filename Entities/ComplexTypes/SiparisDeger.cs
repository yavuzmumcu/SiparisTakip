using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.ComplexTypes
{
    public class SiparisDeger
    {
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public string MusteriAd { get; set; }
        public string PersonelAdSoyad { get; set; }
        public DateTime SiparisTarih { get; set; }
        public DateTime islemTarih { get; set; }
        public string Aciklama { get; set; }
        public string Pazar { get; set; }

    }
}
