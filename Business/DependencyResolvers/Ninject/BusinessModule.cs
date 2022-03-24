using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using MusicLibrary.Business.Concrete;
using Ninject.Modules;


namespace Business.DependencyResolvers.Ninject
{
   public  class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProfessionDal>().To<EfProfessionDal>().InSingletonScope();   //bu classlari singleton edirik cunki data saxlamirlar tek seferlik istifadeye uygundur. entities ve s ucun yararli deyil amma bu cur emelliyat goren classlari singleton edib is goruruk
            Bind<IProfessionService>().To<ProfessionManager>().InSingletonScope();
            
            Bind<IEmployeeDal>().To<EfEmployeeDal>().InSingletonScope();
            Bind<IEmployeeService>().To<EmployeeManager>().InSingletonScope();

            Bind<ICompanyDal>().To<EfCompanyDal>().InSingletonScope();
            Bind<ICompanyService>().To<CompanyManager>().InSingletonScope();

            Bind<IRequestDal>().To<EfRequestDal>().InSingletonScope();
            Bind<IRequestService>().To<RequestManager>().InSingletonScope();

        }
    }
}
