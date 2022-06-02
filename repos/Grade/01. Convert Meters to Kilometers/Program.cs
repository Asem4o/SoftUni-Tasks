using System;

namespace _01._Convert_Meters_to_Kilometers
{
    class Program
    {
        static void Main(string[] args)
        {
            int meturs = int.Parse(Console.ReadLine());
            double km = meturs / 1000d;
            Console.WriteLine($"{km:f2}");
        }
    }
}
