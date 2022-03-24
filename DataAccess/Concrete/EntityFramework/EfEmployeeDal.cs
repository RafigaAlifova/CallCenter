using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.Entityframework
{
    public class EfEmployeeDal : EfEntityRepositoryBase<Employee, CallCenterContext>, IEmployeeDal
    {
    }
}
