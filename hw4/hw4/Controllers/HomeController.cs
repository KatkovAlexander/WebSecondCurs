using System.Linq;
using Microsoft.AspNetCore.Mvc;
using hw4.Models;

namespace hw4.Controllers
{
    public class HomeController : Controller
    {
        Manager db;
        public HomeController(Manager context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View(db.Products.ToList());
        }
    }
}