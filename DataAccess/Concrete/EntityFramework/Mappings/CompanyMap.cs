using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            ToTable("Companies");
            HasKey(m => m.Id);
            Property(m => m.Name).HasColumnName("Name");
            Property(m => m.Vacancy).HasColumnName("Vacancy");
            Property(m => m.ProfessionId).HasColumnName("ProfessionId");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
