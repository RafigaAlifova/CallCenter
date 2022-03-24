using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
namespace DataAccess.Concrete.Entityframework
{
    public class EfRequestDal : EfEntityRepositoryBase<Request, CallCenterContext>, IRequestDal
    {
    }
}
