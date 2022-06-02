using System;

namespace currierExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string service = Console.ReadLine();
            double distance = int.Parse(Console.ReadLine());
            double price = 0;
            double priceForExpress = 0;
            if (service == "standard")
            {
                if (kg < 1)
                {
                    price = 0.03;
                }
                if (kg > 1 && kg < 10)
                {
                    price = 0.05;
                }
                if (kg >= 10 && kg < 40)
                {
                    price = 0.10;
                }
                if (kg >= 40 && kg < 90)
                {
                    price = 0.15;
                }
                if (kg >= 90 && kg < 150)
                {
                    price = 0.20;
                }
            }
            if (service == "express")
            {
                if (kg < 1)
                {
                    priceForExpress = 0.03 * distance;
                    price = 0.03 * 0.8;
                    price *= kg;
                }
                if (kg > 1 && kg < 10)
                {

                    priceForExpress = 0.05 * distance;
                    price = 0.05 * 0.4;
                    price *= kg;
                }
                if (kg >= 10 && kg < 40)
                {
                    priceForExpress = 0.10 * distance;
                    price = 0.10 * 0.05;
                    price *= kg;
                }
                if (kg >= 40 && kg < 90)

                    priceForExpress = 0.15 * distance;
                price = 0.15 * 0.02;
                price *= kg;
            }
            if (kg >= 90 && kg < 150)
            {
                priceForExpress = 0.20 * distance;
                price = 0.20 * 0.01;
                price *= kg;
            }
            distance *= price;
            distance += priceForExpress;
            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {distance:f2} lv."

);
        }
    }
}
