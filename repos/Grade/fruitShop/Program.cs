using System;

namespace fruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeeks = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());
            double banana = 0;
            double apple = 0;
            double orange = 0;
            double grapefruit = 0;
            double kiwi = 0;
            double pineapple = 0;
            double grapes = 0;

            if (dayOfWeeks == "Monday" || dayOfWeeks == "Tuesday" || dayOfWeeks == "Wednesday" || dayOfWeeks== "Thursday" || dayOfWeeks == "Friday")
            {
                if (fruit == "banana")
                {
                    banana = 2.50 * price;
                    Console.WriteLine($"{banana:f2}");
                }
                else if (fruit == "apple")
                {
                    apple = 1.20 * price;
                    Console.WriteLine($"{apple:f2}");
                }
                else if (fruit == "orange")
                {
                    orange = 0.85 * price;
                    Console.WriteLine($"{orange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    grapefruit = 1.45 * price;
                    Console.WriteLine($"{grapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    kiwi = 2.70 * price;
                    Console.WriteLine($"{kiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    pineapple = 5.50 * price;
                    Console.WriteLine($"{pineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    grapes = 3.85 * price;
                    Console.WriteLine($"{grapes:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (dayOfWeeks == "Saturday" || dayOfWeeks =="Sunday")
            {
                if (fruit == "banana")
                {
                    banana = 2.70 * price;
                    Console.WriteLine($"{banana:f2}");
                }
                else if (fruit == "apple")
                {
                    apple = 1.25 * price;
                    Console.WriteLine($"{apple:f2}");
                }
                else if (fruit == "orange")
                {
                    orange = 0.90 * price;
                    Console.WriteLine($"{orange:f2}");
                }
                else if (fruit == "grapefruit")
                {
                    grapefruit = 1.60 * price;
                    Console.WriteLine($"{grapefruit:f2}");
                }
                else if (fruit == "kiwi")
                {
                    kiwi = 3.00 * price;
                    Console.WriteLine($"{kiwi:f2}");
                }
                else if (fruit == "pineapple")
                {
                    pineapple = 5.60 * price;
                    Console.WriteLine($"{pineapple:f2}");
                }
                else if (fruit == "grapes")
                {
                    grapes = 4.20 * price;
                    Console.WriteLine($"{grapes:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            
            
        }
    }
}
