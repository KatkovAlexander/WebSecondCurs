using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hw4.Controllers;
using Microsoft.AspNetCore.Http;
using hw4.Models;


namespace hw4
{
    public static class SampleData
    {
        public static void Initialize(Manager context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(

                    new Product
                    {
                        Id = 0,
                        Category = "T-shirt",
                        Brand = "Emporio Armani",
                        Collection = "Summer 2019",
                        ProductColor = "purple",
                        Amount = 10

                    },

                    new Product
                    {
                        Id = 1,
                        Category = "Jacet",
                        Brand = "Tommy Hilfiger",
                        Collection = "Spring 2018",
                        ProductColor = "black",
                        Amount = 5
                    },

                    new Product
                    {
                        Id = 2,
                        Category = "Pants",
                        Brand = "Hugo Boss",
                        Collection = "Hugo Boss pants 2019",
                        ProductColor = "black",
                        Amount = 5
                    },

                    new Product
                    {
                        Id = 3,
                        Category = "Shoese",
                        Brand = "Nike",
                        Collection = "Airforce 1 2017",
                        ProductColor = "black",
                        Amount = 1
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Brands.Any())
            {
                context.Brands.AddRange(

                    new Brand
                    {
                        BrandId = 3,
                        BrandName = "Emporio Armani",
                    },

                    new Brand
                    {
                        BrandId = 2,
                        BrandName = "Tommy Hilfiger",
                    },

                    new Brand
                    {
                        BrandId = 1,
                        BrandName = "Hugo Boss",
                    },

                    new Brand
                    {
                        BrandId = 0,
                        BrandName = "Nike",
                    }
                    );
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(

                    new Category
                    {
                        CategoryId = 0,
                        CategoryName = "T-shirt",

                    },

                    new Category
                    {
                        CategoryId = 1,
                        CategoryName = "Jacet",
                    },

                    new Category
                    {
                        CategoryId = 2,
                        CategoryName = "Pants",
                    },

                    new Category
                    {
                        CategoryId = 3,
                        CategoryName = "Shoese",
                    }
                    );
                context.SaveChanges();
            }
        
            if (!context.Collections.Any())
            {
                context.Collections.AddRange(

                    new Collection
                    {
                        CollectionId = 0,
                        CollectionName = "Summer 2019",
                    },

                    new Collection
                    {
                        CollectionId = 1,
                        CollectionName = "Spring 2018",
                    },

                    new Collection
                    {
                        CollectionId = 2,
                        CollectionName = "Hugo Boss pants 2019",
                    },

                    new Collection
                    {
                        CollectionId = 3,
                        CollectionName = "Airforce 1 2017",
                    }
                    );

                context.SaveChanges();
            }
        }
    }
}