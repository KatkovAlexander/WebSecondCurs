using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("выберите действие: +, -, *, /");
            string act = Console.ReadLine();
            
            Console.WriteLine("введите а");
            int a = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("введите b");
            int b = Convert.ToInt32(Console.ReadLine());

            if (act == "+")
            {
                Console.WriteLine(a+b);
            }
            else if (act == "-")
            {
                Console.WriteLine(a-b);
            }
            else if (act == "*")
            {
                Console.WriteLine(a*b);
            }
            else
            {
                Console.WriteLine(a/b);
            }
        }
    }
}