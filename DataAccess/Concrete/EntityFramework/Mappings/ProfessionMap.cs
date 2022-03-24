using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class ProfessionMap : EntityTypeConfiguration<Profession>
    {
        public ProfessionMap()
        {
            ToTable("Professions");
            HasKey(m => m.Id);

            Property(m => m.Name).HasColumnName("Name");
            Property(m => m.VacancyCount).HasColumnName("VacancyCount");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); 
        }
    }
}
