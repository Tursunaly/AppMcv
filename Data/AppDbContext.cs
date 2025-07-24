using Microsoft.EntityFrameworkCore;
using EfMvcDemo.Models;

namespace EfMvcDemo.Data // или Databases, в зависимости от структуры
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }
    }
}
