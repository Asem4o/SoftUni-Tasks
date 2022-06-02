using System;

namespace _02._Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double recInSec = double.Parse(Console.ReadLine());
            double distancInMeturs = double.Parse(Console.ReadLine());
            double timeInSecForOneM = double.Parse(Console.ReadLine());

            double timeForTravell = distancInMeturs * timeInSecForOneM;
            double fiftyMeturs = Math.Floor(distancInMeturs / 50) * 30;
            double totalTime = timeForTravell + fiftyMeturs;
            if (recInSec > totalTime)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - recInSec:f2} seconds slower.");
            }
        }
    }
}
