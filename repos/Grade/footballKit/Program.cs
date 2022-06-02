using System;

namespace footballKit
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForTshirt = double.Parse(Console.ReadLine());
            double neededMoneyForBall = double.Parse(Console.ReadLine());

            double priceForShorts = priceForTshirt * 0.75;
            double priceForSoks = priceForShorts * 0.20;
            double priceForShoos = (priceForTshirt + priceForShorts) * 2;
            double wholeSum = priceForTshirt + priceForShorts + priceForSoks + priceForShoos;
            double discount = (wholeSum * 0.15);
            double allMoney = wholeSum - discount;
            if (allMoney >= neededMoneyForBall)
            {
                Console.WriteLine("Yes, he will earn the world-cup replica ball!");
                Console.WriteLine($"His sum is {allMoney:f2} lv.");
            }
            else
            {
                Console.WriteLine("No, he will not earn the world-cup replica ball.");
                Console.WriteLine($"He needs {neededMoneyForBall- allMoney:f2} lv. more.");
            }
           

        }
    }
}
