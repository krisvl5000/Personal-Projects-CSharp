using Microsoft.EntityFrameworkCore;
using WebAppExercise.Models.DBEntities;

namespace WebAppExercise.DAL
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}
