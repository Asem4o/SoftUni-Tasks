using System;

namespace coffeeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string sugur = Console.ReadLine();
            int number = int.Parse(Console.ReadLine());
            double price = 0;
            double discount = 0;
            if (name == "Espresso")
            {
                price = 0.9 * number;
                if (sugur == "Without")
                {
                    discount = price * 0.35;
                    price -= discount;
                }
                 if (sugur == "Normal")
                {
                    price = 1 * number;
                }
                 if (sugur == "Extra")
                {
                    price = 1.20 * number;
                }
                if (number >= 5)
                {
                    price -= price * 0.25;
                }

            }
           else  if (name == "Cappuccino")
            {
                price = 1.00 * number;
                if (sugur == "Without")
                {
                    discount = price * 0.35;
                    price -= discount;
                }
                 if (sugur == "Normal")
                {
                    price = 1.20 * number;
                }
                if (sugur == "Extra")
                {
                    price = 1.60 * number;
                }
            }
             else if (name == "Tea")
            {
                price = 0.5 * number;
                if (sugur == "Without")
                {
                    discount = price * 0.35;
                    price -= discount;
                }
                if (sugur == "Normal")
                {
                    price = 0.60 * number;
                }
                 if (sugur == "Extra")
                {
                    price = 0.70 * number;
                }
            }
            if (price >= 15)
            {
                price -= price * 0.20;
            }
            Console.WriteLine($"You bought {number} cups of {name} for {price:f2} lv.");

        }
    }
}
