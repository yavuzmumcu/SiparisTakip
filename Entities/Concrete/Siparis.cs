using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Siparis : IEntity
    {
        public int SiparisId { get; set; }
        public string SiparisNo { get; set; }
        public int MusteriId { get; set; }
        public int KullaniciId { get; set; }
        public DateTime SiparisTarih { get; set; }
        public DateTime islemTarih { get; set; }
        public string Aciklama { get; set; }

    }
}
