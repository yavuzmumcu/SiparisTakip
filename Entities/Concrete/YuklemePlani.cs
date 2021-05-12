using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class YuklemePlani : IEntity
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public string Ad { get; set; }
        public DateTime islemTarih { get; set; }
    }
}
