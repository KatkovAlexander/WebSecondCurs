using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using WebApplication4.Models;
 
namespace WebApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
            
            //using (ApplicationContext db = new ApplicationContext())
            //{
                
               // var pr1 = new Product{Category = "T-shirt", Brand = "Armani", Collection = "Summer", ProductColor = "Purple", Amount = 2};
                //var pr2 = new Product{Category = "Jacket", Brand = "Hilfiger", Collection = "Spring", ProductColor = "Blue", Amount = 1};
                //var pr3 = new Product{Category = "Pants", Brand = "Boss", Collection = "Boss pants", ProductColor = "Black", Amount = 3};
                //var pr4 = new Product{Category = "Shoes", Brand = "Nike", Collection = "Air Forse 1", ProductColor = "Black", Amount = 4};
                
                //db.Productss.Add(pr1);
                //db.Productss.Add(pr2);
                //db.Productss.Add(pr3);
                //db.Productss.Add(pr4);

                //db.SaveChanges();
                
           // }
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}