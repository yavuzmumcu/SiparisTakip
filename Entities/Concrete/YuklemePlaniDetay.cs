using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class YuklemePlaniDetay : IEntity
    {
        public int Id { get; set; }
        public int YuklemePlaniId { get; set; }
        public int SiparisDetayId { get; set; }
        public int Adet { get; set; }
        public DateTime islemTarih { get; set; }
        
    }
}
