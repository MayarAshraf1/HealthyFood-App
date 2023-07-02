using Microsoft.EntityFrameworkCore;
namespace HealthyFoodWebApplication.Models
{
    public class HealthyFoodDbContext : DbContext
    {
        public HealthyFoodDbContext(DbContextOptions options) : base(options) { }

        public DbSet<CustomerMessage> CustomerMessage { get; set; }
        public DbSet<Logger> Logger { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ShoppingBagItem> ShoppingBag { get; set; }
    }
}
