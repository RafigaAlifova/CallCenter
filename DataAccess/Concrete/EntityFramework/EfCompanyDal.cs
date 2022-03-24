using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
namespace DataAccess.Concrete.Entityframework
{
    public class EfCompanyDal : EfEntityRepositoryBase<Company, CallCenterContext>, ICompanyDal
    {
    }
}
