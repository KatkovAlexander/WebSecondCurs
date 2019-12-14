using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw4.Models
{
    public class Manager : DbContext
    {
        public DbSet<Product> Products;
        public DbSet<Brand> Brands;
        public DbSet<Category> Categories;
        public DbSet<Collection> Collections;

        public Manager(DbContextOptions<Manager> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
