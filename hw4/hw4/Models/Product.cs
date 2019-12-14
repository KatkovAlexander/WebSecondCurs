using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw4.Models
{
    public class Product : DbContext
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Collection { get; set; }
        public string ProductColor { get; set; }
        public int Amount { get; set; }

    }
}