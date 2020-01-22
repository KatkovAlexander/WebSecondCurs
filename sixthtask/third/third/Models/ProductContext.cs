using Microsoft.EntityFrameworkCore;

namespace third.Models
{
    public class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder option)
        {
            if (!option.IsConfigured)
            {
                option.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=ALex54321");
            }
        }
    }
}