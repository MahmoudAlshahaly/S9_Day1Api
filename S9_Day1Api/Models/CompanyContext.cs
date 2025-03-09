using Microsoft.EntityFrameworkCore;

namespace S9_Day1Api.Models
{
    public class CompanyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = .; database = s9companyapi ; integrated security = true ; trustservercertificate = true;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        //
        //
        //
        //

    }
}
