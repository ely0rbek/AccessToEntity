using EntityPro.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityPro.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        public DbSet<Customer> Customers { get; set; }
    }
}
