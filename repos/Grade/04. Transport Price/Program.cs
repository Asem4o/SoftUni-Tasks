using System;

namespace _04._Transport_Price
{
    class Program
    {
        static void Main(string[] args)
        {
            int km = int.Parse(Console.ReadLine());
            string word = Console.ReadLine();

            double taxi = 0.70;
            double bus = 0.09;
            double train = 0.06;
            if (km <20)
            {
                if (word == "day")
                {
                   
                    taxi +=km * 0.79;
                    Console.WriteLine($"{taxi:f2}");
                }
                else if (word == "night")
                {
                    taxi += km * 0.9;
                    Console.WriteLine($"{taxi:f2}");
                }
            }
            else if (km >=20 && km <100) 
            {
                if (word == "day")
                {
                    bus *= km;
                    Console.WriteLine($"{bus:f2}");
                }
                else if (word == "night")
                {
                    bus *= km;
                    Console.WriteLine($"{bus:f2}");
                }

            }
            else if (km >=100)
            {
                if (word == "day")
                {
                    train *= km;
                    Console.WriteLine($"{train:f2}");

                }
                else if (word == "night")
                {
                    train *= km;
                    Console.WriteLine($"{train:f2}");
                }
               

            }
        }
    }
}
