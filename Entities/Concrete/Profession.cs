using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class Profession : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? VacancyCount { get; set; }

    }
}
