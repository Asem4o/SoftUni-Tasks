using System;

namespace _1232321
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double sum = a + b*((a*c/100)/12);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
