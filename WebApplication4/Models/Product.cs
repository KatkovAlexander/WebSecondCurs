using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication4.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Collection { get; set; }
        public string ProductColor { get; set; }
        public int Amount { get; set; }

    }
}