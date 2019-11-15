using System;
using System.Collections.Generic;

namespace SecondHW
{
    public class CategoryActions
    {
        public static List<Category> Categories = new List<Category>();
        
        public static void Add(int id, string name)
        {
            if (Categories.FindIndex(x => x.CategoryId == id) == -1)
            {
                Categories.Add(new Category( id, name));
                Console.WriteLine("Operation completed successfully");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Couldn't add this Category");
        }

        public static void ChangeId(int current_id, int new_id)
        {
            if (Categories.FindIndex(x => x.CategoryId == new_id) != -1)
            {
                Console.WriteLine("No Category with this id");
                Console.WriteLine();
                return;
            }

            var index = Categories.FindIndex(x => x.CategoryId == current_id);

            try
            {
                Categories[index].CategoryId = new_id;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find Category with this id");
            }
            Console.WriteLine();
        }

        public static void Delete(int id)
        {
            var index = Categories.FindIndex(x => x.CategoryId == id);
            try
            {
                Categories.RemoveAt(index);
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't delete Category with this id");
            }
            Console.WriteLine();
        }
        public static void GetAll()
        {
            for (var i = 0; i < Categories.Count; i++)
            {
                Console.WriteLine($"{Categories[i].CategoryId} {Categories[i].CategoryName}");
            }
            Console.WriteLine();
        }

        public static void GetById(int i)
        {
            try
            {
                int index = Categories.FindIndex(x => x.CategoryId == i);
                Console.WriteLine($"{Categories[index].CategoryId} {Categories[index].CategoryName}");
            }
            catch
            {
                Console.WriteLine("Couldn't find Category with this id");
            }
            Console.WriteLine();
        }
    }
}