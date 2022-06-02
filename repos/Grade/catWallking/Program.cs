using System;

namespace catWallking
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallkingInMin = int.Parse(Console.ReadLine());
            int numWalking = int.Parse(Console.ReadLine());
            int cal = int.Parse(Console.ReadLine());
            int minets = wallkingInMin * numWalking;
            int allCal = minets * 5;
            int recivedCal = (cal * 1) / 2;
            if (allCal >=recivedCal)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {allCal}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {allCal}.");
            }
        }
    }
}
