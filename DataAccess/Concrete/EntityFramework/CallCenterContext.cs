using DataAccess.Concrete.EntityFramework.Mappings;
using Entities.Concrete;
using System.Data.Entity;

namespace DataAccess.Concrete.Entityframework
{
    public class CallCenterContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Profession> Professions { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ProfessionMap());
            modelBuilder.Configurations.Add(new RequestMap());
            modelBuilder.Configurations.Add(new CompanyMap());
            modelBuilder.Configurations.Add(new EmployeeMap());

        }
    }
}
