using System;

namespace Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyards = int.Parse(Console.ReadLine());
            double grape = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int workurs = int.Parse(Console.ReadLine());

            double allGrape = vineyards * grape;
            double allWine = (0.40 * allGrape) / 2.5;

            if (allWine > neededWine)
            {
                double wholeWine = (allWine - neededWine);
                double WineForPeople = Math.Floor(wholeWine / workurs);
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(allWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wholeWine)} liters left -> {Math.Ceiling(WineForPeople)} liters per person.");
            }
            else
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine - allWine)} liters wine needed.");
            }
        }
    }
}

