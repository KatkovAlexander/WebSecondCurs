using System.ComponentModel.DataAnnotations;
using System;

namespace Forth.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int Amount { get; set; }
        public string Brand { get; set; }
    }
}