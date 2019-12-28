using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        
        public IActionResult Index(string text)
        {
            if (text == null || text.Trim() == "") return View(db.Productss.ToList());
            var toys = db.Productss.Where(c => c.Category.Contains(text) || 
                                               c.Brand.Contains(text) ||
                                               c.Collection.Contains(text));
            return View(toys);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Product product)
        {
            if (product.Category != null 
                && product.Brand != null
                && product.Collection != null
                && product.ProductColor != null
                && product.Amount != 0)
            {
                db.Productss.Add(product);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return RedirectToAction("Create");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null) return NotFound();
            Product product = db.Productss.Find(id);
            if (product != null)
            {
                return View(product);
            }
            return NotFound();
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Product delete = db.Productss.Find(id);
            if (delete == null)
            {
                return NotFound();
            }
            return View(delete);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Product delete = db.Productss.Find(id);
            if (delete == null)
            {
                return NotFound();
            }
            db.Productss.Remove(delete);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Product product = db.Productss.Find(id);
            if (product != null)
            {
                return View(product);
            }
            return RedirectToAction("Index");
        }
        
    }
}