using System;
using System.Collections.Generic;

namespace SecondHW
{
    public class ProductActions
    {
        public static List<Product> Products = new List<Product>();
        
        public static void Add(int prId, int catId, int brId, string prColor, int prAmount)
        {
            if (Products.FindIndex(x => x.ProductId == prId) == -1)
            {
                Products.Add(new Product(  prId,  catId,  brId,  prColor,  prAmount));
                Console.WriteLine("Operation completed successfully");
                Console.WriteLine();
                return;
            }
            Console.WriteLine("Couldn't add this product");
            Console.WriteLine();
        }

        public static void ChangeId(int CurId, int NewId)
        {
            if (Products.FindIndex(x => x.ProductId == NewId) != -1)
            {
                Console.WriteLine("No product with this id");
                Console.WriteLine();
                return;
            }

            var index = Products.FindIndex(x => x.ProductId == CurId);

            try
            {
                Products[index].ProductId = NewId;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find product with this id");
            }
            Console.WriteLine();
        }
        
        public static void ChangeCategory(int PrId, int NewCatId)
        {
            if (Products.FindIndex(x => x.ProductId == PrId) != -1)
            {
                Console.WriteLine("No product with this id");
                Console.WriteLine();
                return;
            }

            var index = Products.FindIndex(x => x.ProductId == PrId);

            try
            {
                Products[index].CategoryId = NewCatId;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find product with this id");
            }
            Console.WriteLine();
        }

        public static void ChangeBrand(int PrId, int NewBrandId)
        {
            if (Products.FindIndex(x => x.ProductId == PrId) != -1)
            {
                Console.WriteLine("No product with this id");
                Console.WriteLine();
                return;
            }

            var index = Products.FindIndex(x => x.ProductId == PrId);

            try
            {
                Products[index].BrandId = NewBrandId;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find product with this id");
            }
            Console.WriteLine();
        }
        
        public static void ChangeColor(int PrId, string NewColor)
        {
            if (Products.FindIndex(x => x.ProductId == PrId) != -1)
            {
                Console.WriteLine("No product with this id");
                Console.WriteLine();
                return;
            }

            var index = Products.FindIndex(x => x.ProductId == PrId);

            try
            {
                Products[index].ProductColor = NewColor;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find product with this id");
            }
            Console.WriteLine();
        }
        
        public static void ChangeAmount(int PrId, string NewAmount)
        {
            if (Products.FindIndex(x => x.ProductId == PrId) != -1)
            {
                Console.WriteLine("No product with this id");
                Console.WriteLine();
                return;
            }

            var index = Products.FindIndex(x => x.ProductId == PrId);

            try
            {
                Products[index].ProductColor = NewAmount;
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't find product with this id");
            }
            Console.WriteLine();
        }

        public static void Delete(int id)
        {
            var index = Products.FindIndex(x => x.ProductId == id);
            try
            {
                Products.RemoveAt(index);
                Console.WriteLine("Operation completed successfully");
            }
            catch
            {
                Console.WriteLine("Couldn't delete product with this id");
            }
            Console.WriteLine();
        }
        
        public static void GetAll()
        {
            for (var i = 0; i < Products.Count; i++)
            {
                Console.Write($"{Products[i].CategoryId} {Products[i].CategoryId} {Products[i].BrandId} {Products[i].ProductColor} {Products[i].ProductAmount}");
            }
            Console.WriteLine();
        }

        public static void GetById(int i)
        {
            try
            {
                int index = Products.FindIndex(x => x.CategoryId == i);
                Console.Write($"{Products[index].CategoryId} {Products[index].CategoryId} {Products[index].BrandId} {Products[index].ProductColor} {Products[index].ProductAmount}"); }
            catch
            {
                Console.WriteLine("Couldn't find product with this id");
            }
            Console.WriteLine();
        }
    }
}