using System.ComponentModel.DataAnnotations;
using System;

namespace First
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}