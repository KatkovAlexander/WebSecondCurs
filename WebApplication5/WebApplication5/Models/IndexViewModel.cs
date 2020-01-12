using System.Collections.Generic;

namespace WebApplication5.Models
{
    public class IndexViewModel
    {
        public IEnumerable<Product> Users { get; set; }
        public PageViewModel PageViewModel { get; set; }
        public FilterViewModel FilterViewModel { get; set; }
        public SortViewModel SortViewModel { get; set; }
    }
}