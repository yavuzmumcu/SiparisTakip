using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISevkBilgiService
    {
        int Ekle(SevkBilgi sevkBilgi);
        int SevkVarMi(int siparisId);
        SevkBilgi SevkBilgileriGetir(int siparisId);
    }
}
