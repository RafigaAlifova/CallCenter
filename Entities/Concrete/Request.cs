using Core.Entities.Abstract;

namespace Entities.Concrete
{
   public  class Request:IEntity
    {
        public int Id { get; set; }
        public string Details { get; set; }
        public int CompanyId { get; set; }
        public int EmployeeId { get; set; }
    }
}
