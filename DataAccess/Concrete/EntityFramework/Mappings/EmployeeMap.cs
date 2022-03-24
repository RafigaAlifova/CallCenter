using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
        public EmployeeMap()
        {
            ToTable("Employees");
            HasKey(m => m.Id);
            Property(m => m.FirstName).HasColumnName("FirstName");
            Property(m => m.LastName).HasColumnName("LastName");
            Property(m => m.CompanyId).HasColumnName("CompanyId");
            Property(m => m.ProfessionId).HasColumnName("ProfessionId");
            Property(m => m.IsFree).HasColumnName("IsFree");

            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
