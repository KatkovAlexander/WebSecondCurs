using System;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ВВедите длину");
            int length = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("ВВедите max элемент");
            int max = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("ВВедите min элемент");
            int min = Convert.ToInt32(Console.ReadLine());

            int[] mas = new int[length];
            Console.WriteLine();
            for (int i = 0; i < length; i++)
            {
                mas[i] = min;
                if (min < max)
                {
                    min++;
                }

                Console.WriteLine(mas[i]);
            }
            
            

        }
    }
}