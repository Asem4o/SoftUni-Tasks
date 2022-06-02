using System;

namespace _01._Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int dishes = 0;
            int pots = 0;
            int washCount = 1;
            int bottlesCount = int.Parse(Console.ReadLine());

            int detergent = 750 * bottlesCount;
            string input = Console.ReadLine();
            while (input != "End")
            {
                int currentCount = int.Parse(input);
                if (washCount % 3 == 0)
                {
                    detergent -= 15 * currentCount;
                    pots += currentCount;
                }
                else
                {
                    detergent -= 5 * currentCount;
                    dishes += currentCount;
                }
                if (detergent <= 0)
                {
                    break;
                }
                washCount++;
                input = Console.ReadLine();

            }
            if (detergent >= 0)
            {
                Console.WriteLine($"Detergent was enough!");
                Console.WriteLine($"{dishes} dishes and {pots} pots were washed.");
                Console.WriteLine($"Leftover detergent {detergent} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {-detergent} ml. more necessary!");
            }

        }
    }
}
