using System.ComponentModel.DataAnnotations;

namespace Fifthhw.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Category { get; set; }
        public Brand _Brand { get; set; }
        public string Collection { get; set; }
        public string ProductColor { get; set; }
        public int Amount { get; set; }

    }
}