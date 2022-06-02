using System;

namespace _06._Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double price = 0;
            int count = 0;
            double avgSum = 0;
            for (int i = 0; i < clients; i++)
            {
                price = 0;
                count = 0;
                string input = Console.ReadLine();
                while (input != "Finish")
                {

                    if (input == "basket")
                    {
                        price += 1.50;
                        count++;
                    }
                    else if (input == "wreath")
                    {
                        price += 3.80;
                        count++;
                    }
                    else if (input == "chocolate bunny")
                    {
                        price += 7.0;
                        count++;
                    }

                    input = Console.ReadLine();

                }
                if (count % 2 == 0)
                {
                    price *= 0.8;
                }
                avgSum += price;
                Console.WriteLine($"You purchased {count} items for {price:f2} leva.");
            }
            avgSum /= clients;
            Console.WriteLine($"Average bill per client is: {avgSum:f2} leva.");
        }
    }
}
