using Microsoft.EntityFrameworkCore;

namespace Fifthhw.Models
{
    public class Brand: DbContext
    {
        public int BrandId { get; set; }
        public string BrandName { get; set; }
    }
}