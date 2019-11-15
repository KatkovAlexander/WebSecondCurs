using System;
using System.Collections.Generic;

namespace SecondHW
{
    public class BrandActions
    {
        public static List<Brand> Brands = new List<Brand>();
        
        public static void Add(int id, string name)
        {
            if (Brands.FindIndex(x => x.BrandId == id) == -1)
            {
                Brands.Add(new Brand( id, name));
                Console.WriteLine("Operation completed successfully");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Couldn't add this Brand");
            Console.WriteLine();
        }

        public static void ChangeId(int current_id, int new_id)
        {
            if (Brands.FindIndex(x => x.BrandId == new_id) != -1)
            {
                Console.WriteLine("No Brand with this id");
                Console.WriteLine();
                return;
            }

            var index = Brands.FindIndex(x => x.BrandId == current_id);

            try
            {
                Brands[index].BrandId = new_id;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find Brand with this id");
            }
            Console.WriteLine();
        }

        public static void Delete(int id)
        {
            var index = Brands.FindIndex(x => x.BrandId == id);
            try
            {
                Brands.RemoveAt(index);
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't delete Brand with this id");
            }
            Console.WriteLine();
        }
        
        public static void GetAll()
        {
            for (var i = 0; i < Brands.Count; i++)
            {
                Console.WriteLine($"{Brands[i].BrandId} {Brands[i].BrandName}");
            }
            Console.WriteLine();
        }

        public static void GetById(int i)
        {
            try
            {
                int index = Brands.FindIndex(x => x.BrandId == i);
                Console.WriteLine($"{Brands[index].BrandId} {Brands[index].BrandName}");
            }
            catch
            {
                Console.WriteLine("Couldn't find Brand with this id");
            }
            Console.WriteLine();
        }
    }
}