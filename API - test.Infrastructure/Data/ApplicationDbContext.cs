using API___test.Core.Entities;
using Microsoft.EntityFrameworkCore;


namespace API___test.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Team> Teams { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Company> Companies { get; set; }

    }
}
