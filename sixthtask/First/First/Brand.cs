using System.Collections;
using System.Collections.Generic;

namespace First
{
    public partial class Brand
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        
        public virtual ICollection<Product> Products { get; set; }
    }
}