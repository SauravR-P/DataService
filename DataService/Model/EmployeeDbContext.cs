using Microsoft.EntityFrameworkCore;

namespace DataService.Model
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Employee> Employee { get; set;}
        public DbSet<Project> Project { get; set;}
    }
}
