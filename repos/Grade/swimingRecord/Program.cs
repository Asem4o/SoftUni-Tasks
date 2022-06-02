using System;

namespace swimingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSec = double.Parse(Console.ReadLine());
            double distanceInMeturs = double.Parse(Console.ReadLine());
            double timeInSec = double.Parse(Console.ReadLine());

            double distance = distanceInMeturs * timeInSec;
            double add = Math.Floor(distanceInMeturs / 15) * 12.5;
            double totalTime = distance + add;
           
            
            if (recordInSec <=totalTime )
            {
                double needed = totalTime - recordInSec;
                Console.WriteLine($"No, he failed! He was {needed:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalTime:f2} seconds.");
            }

            
        }

    }
}
