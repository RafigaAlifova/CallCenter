using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Company : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProfessionId { get; set; }
        public int Vacancy { get; set; }



    }
}
