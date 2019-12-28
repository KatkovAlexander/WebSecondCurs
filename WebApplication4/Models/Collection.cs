using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    public class Collection : DbContext
    {
        public int CollectionId { get; set; }
        public string CollectionName { get; set; }
    }
}