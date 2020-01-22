using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Forth.Models;
using Microsoft.EntityFrameworkCore;

namespace Forth.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            this.db = context;
            // добавляем начальные данные
            if (db.Products.Count() == 0)
            {
                
                Product user1 = new Product { Category = "Носки", Brand = "Armani", Amount = 26 };
                Product user2 = new Product { Category = "Куртка", Brand = "Tommy Hilfiger", Amount = 24};
                Product user3 = new Product { Category = "Штаны", Brand = "Tommy Hilfiger", Amount = 25};
                Product user4 = new Product { Category = "Ботинки", Brand = "Armani", Amount = 26};
                Product user5 = new Product { Category = "Очки", Brand = "Gucci", Amount = 23};
                Product user6 = new Product { Category = "Футболка", Brand = "Armani", Amount = 23};
                Product user7 = new Product { Category = "Кофта", Brand = "Gucci", Amount = 25};
                Product user8 = new Product { Category = "Свитер", Brand = "Luis Viton", Amount = 24};
                
                db.Products.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);
                db.SaveChanges();
            }
        }
        // жадная загрузка
        public IActionResult EagerLoadingIndex()
        {
            var products = db.Products.ToList();
            return View(products.ToList());
        }

        // явная загрузка
        public IActionResult ExplicitLoadingIndex()
        {
            db.Products.Load();
            return View(db.Products.ToList());
        }

        // ленивая загрузка
        public IActionResult LazyLoadingIndex()
        {
            var products = db.Products.ToList();
            return View(products);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}