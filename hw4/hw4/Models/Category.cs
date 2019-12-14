using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw4.Models
{
    public class Category: DbContext
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}