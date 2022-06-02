using System;

namespace _03._Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string size = Console.ReadLine();
            int sets = int.Parse(Console.ReadLine());
            double small = 2;
            double big = 5;
            double price = 0;
            if (type == "Watermelon")
            {
                if (size == "small")
                {
                    price = 56 * small;
                }
                else if (size == "big")
                {
                    price = 28.70 * big;
                }
            }
            else if (type == "Mango")
            {
                if (size == "small")
                {
                    price = 36.66 * small;
                }
                else if (size == "big")
                {
                    price = 19.60 * big;
                }
            }
            else if (type == "Pineapple")
            {
                if (size == "small")
                {
                    price = 42.10*small;
                }
                else if (size == "big")
                {
                    price = 24.80 * big;
                }
            }
            else if (type == "Raspberry")
            {
                if (size == "small")
                {
                    price = 20.0 * small;
                }
                else if (size == "big")
                {
                    price = 15.20 * big;
                }
            }
            price *= sets;
            if (price >= 400 && price <= 1000)
            {
                price *= 0.85;
            }
            else if (price >1000)
            {
                price *= 0.5;
            }
         
            Console.WriteLine($"{price:f2} lv. ");
        }
    }
}
