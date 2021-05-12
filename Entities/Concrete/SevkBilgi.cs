using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SevkBilgi : IEntity
    {
        public int SevkBilgiId { get; set; }
        public int SiparisId { get; set; }
        public int SevkAracId { get; set; }
        public string SevkAdres { get; set; }
    }
}
