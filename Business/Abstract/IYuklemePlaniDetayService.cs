using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYuklemePlaniDetayService
    {
        int Ekle(YuklemePlaniDetay yuklemePlaniDetay);

        List<YuklemePlaniDetayListe> YuklemePlaniDetayListele(int yuklemePlaniId);

        int Sil(YuklemePlaniDetay yuklemePlaniDetay);

        List<YuklemePlaniDetay> YuklemePlaniDetayListeleBySiparisId(int siparisDetayId);
    }
}
