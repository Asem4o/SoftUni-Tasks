using System;

namespace _02._Pounds_to_Dollars
{
    class Program
    {
        static void Main(string[] args)
        {
            double usd = double.Parse(Console.ReadLine());
            Console.WriteLine($"{usd * 1.31:f3}");
        }
    }
}
