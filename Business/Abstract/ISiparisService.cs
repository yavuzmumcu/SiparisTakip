using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISiparisService
    {
        int Ekle(Siparis siparis);

        SiparisDeger siparisDegerleriniGetir(int siparisId);

        List<Siparisler> SiparisleriListele();

        int Sil(Siparis siparis);
    }
}
