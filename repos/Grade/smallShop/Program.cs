using System;

namespace smallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double coffee = 0;
            double water = 0;
            double beer = 0;
            double sweets = 0;
            double peanuts = 0;

            if (town == "Sofia")
            {
                if (product == "coffee")
                {
                    coffee = 0.50;
                    quantity = quantity * coffee;
                    Console.WriteLine(quantity);
                }
                else if (product == "water")
                {
                    water = 0.80;
                    quantity = quantity * water;
                    Console.WriteLine(quantity);
                }
                else if (product == "beer")
                {
                    beer = 1.20;
                    quantity = quantity * beer;
                    Console.WriteLine(quantity);
                }
                else if (product == "sweets")
                {
                    sweets = 1.45;
                    quantity = quantity * sweets;
                    Console.WriteLine(quantity);
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.60;
                    quantity = quantity * peanuts;
                    Console.WriteLine(quantity);
                }

            }
            else if (town == "Plovdiv")
            {

                if (product == "coffee")
                {
                    coffee = 0.40;
                    quantity = quantity * coffee;
                    Console.WriteLine(quantity);
                }
                else if (product == "water")
                {
                    water = 0.70;
                    quantity = quantity * water;
                    Console.WriteLine(quantity);
                }
                else if (product == "beer")
                {
                    beer = 1.15;
                    quantity = quantity * beer;
                    Console.WriteLine(quantity);
                }
                else if (product == "sweets")
                {
                    sweets = 1.30;
                    quantity = quantity * sweets;
                    Console.WriteLine(quantity);
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.50;
                    quantity = quantity * peanuts;
                    Console.WriteLine(quantity);
                }

            }
            else if (town == "Varna")
            {
                if (product == "coffee")
                {
                    coffee = 0.45;
                    quantity = quantity * coffee;
                    Console.WriteLine(quantity);
                }
                else if (product == "water")
                {
                    water = 0.70;
                    quantity = quantity * water;
                    Console.WriteLine(quantity);
                }
                else if (product == "beer")
                {
                    beer = 1.10;
                    quantity = quantity * beer;
                    Console.WriteLine(quantity);
                }
                else if (product == "sweets")
                {
                    sweets = 1.35;
                    quantity = quantity * sweets;
                    Console.WriteLine(quantity);
                }
                else if (product == "peanuts")
                {
                    peanuts = 1.55;
                    quantity = quantity * peanuts;
                    Console.WriteLine(quantity);
                }
            }
        }
    }
}
