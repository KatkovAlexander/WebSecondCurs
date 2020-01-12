using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication5.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        
        public HomeController(ApplicationContext context)
        {
            this.db = context;
            // добавляем начальные данные
            if (db.Brands.Count() == 0)
            {
                Brand armani = new Brand { Name = "Armani" };
                Brand lv = new Brand { Name = "Luis Viton" };
                Brand gucci = new Brand { Name = "Gucci" };
                Brand hilfiger = new Brand { Name = "Tommy Hilfiger" };
 
                Product user1 = new Product { Category = "Носки", Brand = gucci, Amount = 26, CreationDate = DateTime.Now };
                Product user2 = new Product { Category = "Куртка", Brand = hilfiger, Amount = 24, CreationDate = DateTime.Now };
                Product user3 = new Product { Category = "Штаны", Brand = hilfiger, Amount = 25, CreationDate = DateTime.Now };
                Product user4 = new Product { Category = "Ботинки", Brand = hilfiger, Amount = 26, CreationDate = DateTime.Now };
                Product user5 = new Product { Category = "Очки", Brand = hilfiger, Amount = 23, CreationDate = DateTime.Now };
                Product user6 = new Product { Category = "Футболка", Brand = armani, Amount = 23, CreationDate = DateTime.Now };
                Product user7 = new Product { Category = "Кофта", Brand = armani, Amount = 25, CreationDate = DateTime.Now };
                Product user8 = new Product { Category = "Свитер", Brand = lv, Amount = 24, CreationDate = DateTime.Now };
 
                db.Brands.AddRange(armani, lv, gucci, hilfiger);
                db.Products.AddRange(user1, user2, user3, user4, user5, user6, user7, user8);
                db.SaveChanges();
            }
        }
        public async Task<IActionResult> Index(int? company, string name, int page = 1, 
            SortState sortOrder = SortState.CategoryAsc)
        {
            int pageSize = 5;
 
            //фильтрация
            IQueryable<Product> users = db.Products.Include(x=>x.Brand);
 
            if (company != null && company != 0)
            {
                users = users.Where(p => p.BrandId == company);
            }
            if (!String.IsNullOrEmpty(name))
            {
                users = users.Where(p => p.Category.Contains(name));
            }
 
            // сортировка
            switch (sortOrder)
            {
                case SortState.CategoryDesc:
                    users = users.OrderByDescending(s => s.Category);
                    break;
                case SortState.AmountAsc:
                    users=users.OrderBy(s => s.Amount);
                    break;
                case SortState.AmountDesc:
                    users = users.OrderByDescending(s => s.Amount);
                    break;
                case SortState.BrandAsc:
                    users=users.OrderBy(s => s.Brand.Name);
                    break;
                case SortState.BrandDesc:
                    users=users.OrderByDescending(s => s.Brand.Name);
                    break;
                default:
                    users = users.OrderBy(s => s.Category);
                    break;
            }
 
            // пагинация
            var count = await users.CountAsync();
            var items = await users.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
 
            // формируем модель представления
            IndexViewModel viewModel = new IndexViewModel
            {
                PageViewModel = new PageViewModel(count, page, pageSize),
                SortViewModel = new SortViewModel(sortOrder),
                FilterViewModel = new FilterViewModel(db.Brands.ToList(), company, name),
                Users = items
            };
            return View(viewModel);
        }
        
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string Add, string Back, ProductTemp pr)
        {
            var btn = Add ?? Back;
            if (btn == Back)
            {
                return RedirectToAction("Index");
            }
            else
            {
                Product temp = new Product
                    {Category = pr.Category, Amount = pr.Amount, CreationDate = DateTime.Now, Brand = pr.Brand};
                if (db.Products.Contains(temp))
                {
                    return BadRequest();
                }

                if (!db.Brands.Contains(pr.Brand))
                {
                    db.Brands.Add(pr.Brand);
                }

                db.Products.Add(temp);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
        }
    }
}