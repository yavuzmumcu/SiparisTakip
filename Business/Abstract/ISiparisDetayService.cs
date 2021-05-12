using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ISiparisDetayService
    {
        int Ekle(SiparisDetay siparisDetay);

        List<SiparisDetayDeger> SiparisDetayDegerleriListele(int siparisId);

        int Sil(SiparisDetay siparisDetay);

        SiparisDetay SiparisDetay(int siparisId);

        int Guncelle(SiparisDetay siparisDetay);
    }
}
