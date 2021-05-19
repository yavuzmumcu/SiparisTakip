using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SiparisDetay : IEntity
    {
        public int SiparisDetayId { get; set; }
        public int SiparisId { get; set; }
        public int UrunId { get; set; }
        public int KaliteId { get; set; }
        public int RenkId { get; set; }
        public string Logo { get; set; }
        public int Adet { get; set; }
        public DateTime islemTarih { get; set; }
        public string Aciklama { get; set; }
        public int YuklemeTipId { get; set; }
        public int PaletId { get; set; }
        public string Kutu { get; set; }

        public int KalanAdet { get; set; }
    }
}
