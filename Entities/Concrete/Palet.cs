using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Palet : IEntity
    {
        public int PaletId { get; set; }
        public string PaletAd { get; set; }
    }
}
