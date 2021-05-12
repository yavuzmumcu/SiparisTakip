using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Kullanici :IEntity
    {
        public int KullaniciId { get; set; }
        public string KullaniciAd { get; set; }
        public string Sifre { get; set; }
        public string PersonelAdSoyad { get; set; }
        public string Pazar { get; set; }
    }
}
