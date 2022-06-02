using System;

namespace _06._Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double price = 0;
            if (km <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.75;
                }
                else if (season == "Summer")
                {
                    price = 0.9;
                }
                else if (season == "Winter")
                {
                    price = 1.05;
                }
            }
            else if (km > 5000 && km <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                {
                    price = 0.95;
                }
                else if (season == "Summer")
                {
                    price = 1.1;
                }
                else if (season == "Winter")
                {
                    price = 1.25;
                }
            }
            else if (km > 10000 && km <= 20000)
            {
                price = 1.45;
            }
            price = km * price * 4;
            price *= 0.9;
            Console.WriteLine($"{price:f2}");

        }
    }
}
