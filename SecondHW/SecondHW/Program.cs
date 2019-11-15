using System;

namespace SecondHW
{
    class Program
    {
        static void Main(string[] args)
        {
            string mode = null;
            while (mode != "0")
            {
                Console.WriteLine("To search product - click 1\nTo enter admin mode - click 9\nTo exit - click 0");
                mode = Console.ReadLine();
                Console.WriteLine();
                if (mode == "1")
                {
                    string picked = null;
                    while (picked != "0")
                    {
                        Console.WriteLine(
                            "To see all Brands - click 1\nTo see brand by its id - click 2\n" +
                            "To see all Categories - click 3\nTo see Category by its id - click 4\n" +
                            "To see all Collections - click 5\nTo see collection by its id - click 6\n" +
                            "To see all products - click 7\nTo see product by its id - click 8\n" +
                            "To exit - click 0");
                        picked = Console.ReadLine();
                        Console.WriteLine();
                        if (picked == "1")
                        {
                            BrandActions.GetAll();
                        }
                        else if (picked == "2")
                        {
                            Console.WriteLine("Write brand ID witch u want to see:");
                            string id = Console.ReadLine();
                            
                            try
                            {
                                BrandActions.GetById(Convert.ToInt32(id));
                            }
                            catch
                            {
                                Console.WriteLine("Operation couldn't be complete'");
                                Console.WriteLine();
                            }
                            
                        }
                        else if (picked == "3")
                        {
                            CategoryActions.GetAll();
                        }
                        else if (picked == "4")
                        {
                            Console.WriteLine("Write сategory ID witch u want to see:");
                            string id = Console.ReadLine();
    
                            try
                            {
                                CategoryActions.GetById(Convert.ToInt32(id));
                            }
                            catch
                            {
                                Console.WriteLine("Operation couldn't be complete'");
                                Console.WriteLine();
                            }
                        }
                        else if (picked == "5")
                        {
                            CollectionActions.GetAll();
                        }
                        else if (picked == "6")
                        {
                            Console.WriteLine("Write collection ID witch u want to see:");
                            string id = Console.ReadLine();

                            try
                            {
                                CollectionActions.GetById(Convert.ToInt32(id));
                            }
                            catch
                            {
                                Console.WriteLine("Operation couldn't be complete'");
                                Console.WriteLine();
                            }
                        }
                        else if (picked == "7")
                        {
                            ProductActions.GetAll();
                        }
                        else if (picked == "8")
                        {
                            Console.WriteLine("Write product ID witch u want to see:");
                            string id = Console.ReadLine();

                            try
                            {
                                ProductActions.GetById(Convert.ToInt32(id));
                            }
                            catch
                            {
                                Console.WriteLine("Operation couldn't be complete'");
                                Console.WriteLine();
                            }
                        }
                        else if(picked == "9"){}
                        else
                        {
                            Console.WriteLine("You made mistake");
                        }
                    }
                }
                else if (mode == "9")
                {
                    string picked = null;
                    while (picked != "0")
                    {
                        Console.WriteLine("To do actions with Brand - click 1\nTo do actions with Category - click 2\n" +
                                          "To do actions with Collection - click 3\nTo do actions with Product - click 4\n" +
                                          "To exit - click 0");
                        picked = Console.ReadLine();
                        Console.WriteLine();

                        if (picked == "1")
                        {
                            string action = null;
                            while (action != "0")
                            {
                                Console.WriteLine("To add brand - click 1 \nTo change brand ID - click 2\nTo delete brand - click 3\n" +
                                                  "To exit - click 0");
                                action = Console.ReadLine();
                                if (action == "1")
                                {
                                    Console.WriteLine("Write brand ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write brand name");
                                    string name = Console.ReadLine();

                                    try
                                    {
                                        BrandActions.Add(Convert.ToInt32(id), name);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                    }
                                }
                                else if (action == "2")
                                {
                                    Console.WriteLine("Write old brand ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new brand ID");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        BrandActions.ChangeId(Convert.ToInt32(id), Convert.ToInt32(newID));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "3")
                                {
                                    Console.WriteLine("Write brand ID witch u want to delete");
                                    string id = Console.ReadLine();

                                    try
                                    {
                                        BrandActions.Delete(Convert.ToInt32(id));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                    }
                                }
                                else if (action == "0") {}
                                else
                                {
                                    Console.WriteLine("Wrong input data\n");
                                }
                            }

                        }
                        
                        else if (picked == "2")
                        {
                            string action = null;
                            while (action != "0")
                            {
                                Console.WriteLine("To add сategory - click 1 \nTo change сategory ID - click 2\n" +
                                                  "To delete сategory - click 3\nTo exit - click 0");
                                action = Console.ReadLine();
                                if (action == "1")
                                {
                                    Console.WriteLine("Write сategory ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write сategory name");
                                    string name = Console.ReadLine();

                                    try
                                    {
                                        CategoryActions.Add(Convert.ToInt32(id), name);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "2")
                                {
                                    Console.WriteLine("Write old сategory ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new сategory ID");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        CategoryActions.ChangeId(Convert.ToInt32(id), Convert.ToInt32(newID));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                    }
                                }
                                else if (action == "3")
                                {
                                    Console.WriteLine("Write сategory ID witch u want to delete");
                                    string id = Console.ReadLine();

                                    try
                                    {
                                        CategoryActions.Delete(Convert.ToInt32(id));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "0") {}
                                else
                                {
                                    Console.WriteLine("Wrong input data\n");
                                }
                            }
                            
                        }
                        
                        else if (picked == "3")
                        {
                            string action = null;
                            while (action != "0")
                            {
                                Console.WriteLine("To add collection - click 1 \nTo change collection ID - click 2\n" +
                                                  "To delete collection - click 3\nTo exit - click 0");
                                action = Console.ReadLine();
                                if (action == "1")
                                {
                                    Console.WriteLine("Write brand ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write brand name");
                                    string name = Console.ReadLine();

                                    try
                                    {
                                        CollectionActions.Add(Convert.ToInt32(id), name);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "2")
                                {
                                    Console.WriteLine("Write old collection ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new collection ID");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        CollectionActions.ChangeId(Convert.ToInt32(id), Convert.ToInt32(newID));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                
                                else if (action == "3")
                                {
                                    Console.WriteLine("Write collection ID witch u want to delete");
                                    string id = Console.ReadLine();

                                    try
                                    {
                                        CollectionActions.Delete(Convert.ToInt32(id));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "0") {}
                                else
                                {
                                    Console.WriteLine("Wrong input data\n");
                                }
                            }
                        }
                        
                        else if (picked == "4")
                        {
                            string action = null;
                            while (action != "0")
                            {
                                Console.WriteLine("To add product - click 1 \nTo change product ID - click 2\nTo change product сategory - click 3\n To change product brand - click 4 \n" +
                                              "To change product color - click 5 \nTo change product amount - click 6\n" +
                                              "To delete product - click 7\nTo exit - click 0");
                                action = Console.ReadLine();
                                if (action == "1")
                                {
                                    Console.WriteLine("Write product ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write product сategory Id");
                                    string catid = Console.ReadLine();
                                    Console.WriteLine("Write product brand Id");
                                    string brid = Console.ReadLine();
                                    Console.WriteLine("Write product color");
                                    string color = Console.ReadLine();
                                    Console.WriteLine("Write product amount");
                                    string amount = Console.ReadLine();

                                    try
                                    {
                                        ProductActions.Add(Convert.ToInt32(id), Convert.ToInt32(catid), Convert.ToInt32(brid), color, Convert.ToInt32(amount));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "2")
                                {
                                    Console.WriteLine("Write old product ID");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new product ID");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        ProductActions.ChangeId(Convert.ToInt32(id), Convert.ToInt32(newID));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "3")
                                {
                                    Console.WriteLine("Write product ID which сategory ID u want to change");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new сategory ID");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        ProductActions.ChangeCategory(Convert.ToInt32(id), Convert.ToInt32(newID));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "4")
                                {
                                    Console.WriteLine("Write product ID which brand ID u want to change");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new сategory ID");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        ProductActions.ChangeBrand(Convert.ToInt32(id), Convert.ToInt32(newID));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "5")
                                {
                                    Console.WriteLine("Write product ID which color u want to change");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new color");
                                    string newColor = Console.ReadLine();
                                    
                                    try
                                    {
                                        ProductActions.ChangeColor(Convert.ToInt32(id), newColor);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "6")
                                {
                                    Console.WriteLine("Write product ID which amount u want to change");
                                    string id = Console.ReadLine();
                                    Console.WriteLine("Write new amount");
                                    string newID = Console.ReadLine();
                                    
                                    try
                                    {
                                        ProductActions.ChangeAmount(Convert.ToInt32(id), newID);
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "7")
                                {
                                    Console.WriteLine("Write product ID witch u want to delete");
                                    string id = Console.ReadLine();

                                    try
                                    {
                                        ProductActions.Delete(Convert.ToInt32(id));
                                    }
                                    catch
                                    {
                                        Console.WriteLine("Operation couldn't be complete\n");
                                        Console.WriteLine();
                                    }
                                }
                                else if (action == "0") {}
                                else
                                {
                                    Console.WriteLine("Wrong input data\n");
                                }
                            }
                            
                        }
                        else if (picked == "0"){}
                        else
                        {
                            Console.WriteLine("You made mistake\n");
                        }
                        Console.WriteLine();
                        
                    }
                    
                }
                else if (mode == "080400")
                {
                    
                }
                else if (mode == "0")
                {
                    Console.WriteLine("This is the end, my friend\n");
                }
                
                else
                {
                    Console.WriteLine("You made mistake\n");
                    Console.WriteLine();
                }
            }
        }
    }
}