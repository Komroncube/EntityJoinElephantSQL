using EntityJoin.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityJoin.DataAccess
{
    public class DemoDbContext : DbContext
    {
        public DemoDbContext(DbContextOptions<DemoDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Laptop> Laptops { get; set; }
    }
}
