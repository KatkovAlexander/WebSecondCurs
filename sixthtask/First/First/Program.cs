using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace First
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (shopdbContext db = new shopdbContext())
            {
                // получаем объекты из бд и выводим на консоль
                var product = db.Products.ToList();
                Console.WriteLine("Список объектов:");
                foreach (Product u in product)
                {
                    Console.WriteLine($"id {u.Id}, Category {u.Category}, Amount {u.Amount}, Brand {u.Brand}");
                }
            }
            Console.ReadKey();
        }
        
    }
}
h