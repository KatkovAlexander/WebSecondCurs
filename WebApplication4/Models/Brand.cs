using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Brand: DbContext
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}