namespace WebApplication5.Models
{
    public class ProductTemp
    {
        public string Category { get; set; }
        public int Amount { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}