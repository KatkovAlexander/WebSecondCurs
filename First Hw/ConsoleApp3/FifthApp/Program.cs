using System;

namespace FifthApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("y = x^a^a + a^a^x +a^x^a");
            Console.WriteLine("введите x >=0");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите a >=0");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=: ");
            Console.WriteLine( Math.Pow(Math.Pow(x,a),a) + Math.Pow(Math.Pow(a,a),x) + Math.Pow(Math.Pow(a,x),a) );
            
            
            Console.WriteLine("y = x/2 * sqrt(x^2 + a^2) + a^2/2");
            Console.WriteLine("введите x >=0");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите a >=0");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=: ");
            Console.WriteLine(x/2 * Math.Sqrt(Math.Pow(x,2) + Math.Pow(a,2)) + Math.Pow(a,2)/2);
            
            Console.WriteLine("y = 1/2a * ln |(x-a)/(x+a)");
            Console.WriteLine("введите x >=0");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите a >=0");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=: ");
            Console.WriteLine(1/2*a+Math.Log((x-a)/(x+a),Math.E));
            
            Console.WriteLine("y = (a^(-x) * arcsin(a^(-x^2)) / sqrt(1 - a^(-2*x^2) + 1/2 ln (1 - a^(-2x^2))");
            Console.WriteLine("введите x >=0");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите a >=0");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("y=: ");
            Console.WriteLine( Math.Pow(a,x*-1) * (Math.Asin(Math.Pow(a, Math.Pow(x,2)*-1 )) / Math.Sqrt(1 - Math.Pow(a,-2*Math.Pow(x,2)) )) + 1/2 * Math.Log(1 - Math.Pow(a,-2*Math.Pow(x,2)),Math.E));
            
        }
    }
}