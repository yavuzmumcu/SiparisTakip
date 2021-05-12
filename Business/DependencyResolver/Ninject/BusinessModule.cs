using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.AdoNet;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolver.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISiparisService>().To<SiparisManager>().InSingletonScope();
            Bind<ISiparisDal>().To<AdSiparisDal>().InSingletonScope();

            Bind<IMusteriService>().To<MusteriManager>().InSingletonScope();
            Bind<IMusteriDal>().To<AdMusteriDal>().InSingletonScope();

            Bind<IKullaniciService>().To<KullaniciManager>().InSingletonScope();
            Bind<IKullaniciDal>().To<AdKullaniciDal>().InSingletonScope();

            Bind<IUrunService>().To<UrunManager>().InSingletonScope();
            Bind<IUrunDal>().To<AdUrunDal>().InSingletonScope();

            Bind<IKaliteService>().To<KaliteManager>().InSingletonScope();
            Bind<IKaliteDal>().To<AdKaliteDal>().InSingletonScope();

            Bind<IRenkService>().To<RenkManager>().InSingletonScope();
            Bind<IRenkDal>().To<AdRenkDal>().InSingletonScope();

            Bind<ISiparisDetayService>().To<SiparisDetayManager>().InSingletonScope();
            Bind<ISiparisDetayDal>().To<AdSiparisDetayDal>().InSingletonScope();

            Bind<IOtherEntitiesService>().To<OtherEntitiesManager>().InSingletonScope();
            Bind<IOtherEntitiesDal>().To<AdOtherEntitiesDal>().InSingletonScope();

            Bind<ISevkBilgiService>().To<SevkBilgiManager>().InSingletonScope();
            Bind<ISevkBilgiDal>().To<AdSevkBilgiDal>().InSingletonScope();

            Bind<IYuklemePlaniService>().To<YuklemePlaniManager>().InSingletonScope();
            Bind<IYuklemePlaniDal>().To<AdYuklemePlaniDal>().InSingletonScope();


            Bind<IYuklemePlaniDetayService>().To<YuklemePlaniDetayManager>().InSingletonScope();
            Bind<IYuklemePlaniDetayDal>().To<AdYuklemePlaniDetayDal>().InSingletonScope();
        }
    }
}
