using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Employee : IEntity
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ProfessionId { get; set; }
        public bool IsFree { get; set; }

    }
}
