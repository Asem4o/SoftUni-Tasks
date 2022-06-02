using System;

namespace Courier_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            double kg = double.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            int distance = int.Parse(Console.ReadLine());
            double price = 0;
            double priceforShiping = 0;
            

            if (name== "standard")
            {
                if (kg <1 )
                {
                    price = 0.03;
                    priceforShiping = 0.03 * price;
                }
                else if (kg >= 1 && kg <10)
                {
                    price = 0.05;
                    priceforShiping = 0.05 * price;
                }
                else if (kg >= 10 && kg < 40)
                {
                    price = 0.10;
                    priceforShiping = 0.10 * price;
                }
                else if (kg >= 40 && kg < 90)
                {
                    price = 0.15;
                    priceforShiping = 0.15 * price;
                }
                else if (kg >= 90 && kg < 150)
                {
                    price = 0.20;
                    priceforShiping = 0.20 * price;
                }

            }
            else if (name == "express")
            {
                if (kg < 1)
                {
                    price = 0.03 * 0.8;
                    price = kg * price;
                    priceforShiping = 0.03 * price;
                }
                else if (kg >= 1 && kg < 10)
                {
                    price = 0.05 * 0.4;
                    price = kg * price;
                    priceforShiping = 0.05 * price;
                }
                else if (kg >= 10 && kg < 40)
                {
                    price = 0.10*0.05;
                    price = kg * price;
                    priceforShiping = 0.10 * price;
                }
                else if (kg >= 40 && kg < 90)
                {
                    price = 0.15*0.02;
                    price = kg * price;
                    priceforShiping = 0.15 * distance;

                }
                else if (kg >= 90 && kg < 150)
                {
                    price = 0.20*0.01;
                    priceforShiping = 0.20 * distance;
                    price = kg * price;
                   
                }
            }
            double gg = distance * price;
            double final =gg + priceforShiping;
            Console.WriteLine($"The delivery of your shipment with weight of {kg:f3} kg. would cost {final:f2} lv.");
        }
    }
}
