using System;
using Microsoft.VisualBasic.CompilerServices;

namespace ForthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int length = rnd.Next(0, 10);
            
            int[] mas = new int[length];
            
            for (int i = 0; i < length; i++)
            {
                mas[i] = rnd.Next(0, 100);
            }
            
            Console.WriteLine("1) сортировать в порядке возрастания");
            Console.WriteLine("2) сортировать в порядке убывания");
            string ans = Console.ReadLine();

            if (ans == "1")
            {
                int temp;
                    for (int i = 0; i < mas.Length - 1; i++)
                    {
                        bool f = false;
                        for (int j = 0; j < mas.Length - i - 1; j++)
                        {
                            if (mas[j+1] < mas[j])
                            {
                                f = true;
                                temp = mas[j+1];
                                mas[j+1] = mas[j];
                                mas[j] = temp;
                            }                   
                        }
                        if(!f) break;
                    }
            }
            else if (ans == "2")
            {
                int temp;
                for (int i = 0; i < mas.Length - 1; i++)
                {
                    bool f = false;
                    for (int j = 0; j < mas.Length - i - 1; j++)
                    {
                        if (mas[j+1] > mas[j])
                        {
                            f = true;
                            temp = mas[j+1];
                            mas[j+1] = mas[j];
                            mas[j] = temp;
                        }                   
                    }
                    if(!f) break;
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
            
            for (int i = 0; i < length; i++)
            {
               Console.Write(mas[i]);
               Console.Write(" ");
            }
        }
    }
}