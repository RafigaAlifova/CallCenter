using Entities.Concrete;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Concrete.EntityFramework.Mappings
{
    public class RequestMap : EntityTypeConfiguration<Request>
    {
        public RequestMap()
        {
            ToTable("Requests");
            HasKey(m => m.Id);

            Property(m => m.Details).HasColumnName("Details");
            Property(m => m.CompanyId).HasColumnName("CompanyId");
            Property(m => m.EmployeeId).HasColumnName("EmployeeId");
            Property(m => m.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
        }
    }
}
