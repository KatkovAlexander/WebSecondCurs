using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace First
{
    public partial class shopdbContext : DbContext
        { 
            public shopdbContext()
            {
            }

            public shopdbContext(DbContextOptions<shopdbContext> options)
                : base(options)
            {
            }

            public virtual DbSet<Brand> Brands { get; set; }
            public virtual DbSet<Product> Products { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder option)
            {
                if (!option.IsConfigured)
                {
                    option.UseNpgsql("Host=localhost;Port=5432;Database=usersdb2;Username=postgres;Password=ALex54321");
                }
            }

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Product>(entity =>
                {
                    entity.HasIndex(e => e.Id);

                    entity.HasOne(d => d.Brand)
                        .WithMany(p => p.Products)
                        .HasForeignKey(d => d.BrandId);
                });

                OnModelCreatingPartial(modelBuilder);
            }

            partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
        }
    }