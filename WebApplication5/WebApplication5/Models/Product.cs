using System.ComponentModel.DataAnnotations;
using System;

namespace WebApplication5.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public DateTime CreationDate { get; set; }
        public TimeSpan Lifetime => DateTime.Now - CreationDate;
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}