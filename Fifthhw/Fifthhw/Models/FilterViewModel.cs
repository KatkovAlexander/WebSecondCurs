using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace Fifthhw.Models
{
    public class FilterViewModel
    {
        public FilterViewModel(IList<Brand> types, int? type, string name)
        {
            // устанавливаем начальный элемент, который позволит выбрать всех
            types.Insert(0, new Brand { BrandName = "All", BrandId = 0});
            Types = new SelectList(types, "Id", "Name", type);
            SelectedType = type;
            SelectedName = name;
        }
        public SelectList Types { get; } // список брендов
        public int? SelectedType { get; }   // выбранный бренд
        public string SelectedName { get; }    // введенное имя
    }
}