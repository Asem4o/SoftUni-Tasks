using System;

namespace lunchBreak
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfSerial = Console.ReadLine();
            int episode = int.Parse(Console.ReadLine());
            double timeBreaking = int.Parse(Console.ReadLine());

            double timeForLunch = timeBreaking / 8;
            double timeForRest = timeBreaking / 4;
            double restedTime =timeBreaking - timeForLunch - timeForRest;
            
            if (restedTime>=episode)
            {
               double timeLeft =Math.Ceiling(restedTime - episode);
                Console.WriteLine($"You have enough time to watch {nameOfSerial} and left with {timeLeft} minutes free time.");
            }
            else
            {
                double neededTime =Math.Ceiling(episode - restedTime);
                Console.WriteLine($"You don't have enough time to watch {nameOfSerial}, you need {neededTime} more minutes.");
            }
           

           
        }
    }
}
