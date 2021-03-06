using Entities.ComplexTypes;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IYuklemePlaniService
    {
        int Ekle(YuklemePlani yuklemePlani);

        YuklemePlaniDeger yuklemePlaniDegerleri(int yuklemePlaniId);

        List<YuklemePlaniDeger> YuklemePlanlariListele();
    }
}
