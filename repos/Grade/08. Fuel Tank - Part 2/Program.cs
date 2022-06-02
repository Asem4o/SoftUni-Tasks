using System;

namespace _08._Fuel_Tank___Part_2
{
    class Program
    {
        static void Main(string[] args)
        {

            string fuel = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();
            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            double price = 0;
            if (fuel == "Gas")
            {
                if (clubCard == "Yes")
                {
                    gas -= 0.08;
                    price = km * gas;
                }
                else
                {
                    price = km * gas;
                }
            }
            else if (fuel == "Gasoline")
            {
                if (clubCard == "Yes")
                {
                    gasoline -= 0.18;
                    price = km * gasoline;
                }
                else
                {
                    price = km * gasoline;
                }
            }
            else if (fuel == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    diesel -= 0.12;
                    price = km * diesel;
                }
                else
                {
                    price = km * diesel;
                }
            }
            if (km >= 20 && km <= 25)
            {
                price *= 0.92;

            }
            else if (km > 25)
            {
                price *= 0.90;
            }

            Console.WriteLine($"{price:f2} lv.");

        }
    }
}
