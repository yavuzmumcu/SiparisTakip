using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class SevkArac : IEntity
    {
        public int SevkAracId { get; set; }
        public string SevkAracAd { get; set; }
    }
}
