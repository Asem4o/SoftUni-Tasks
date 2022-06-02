using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForExcursion = double.Parse(Console.ReadLine());
            int countPuzzle = int.Parse(Console.ReadLine());
            int countSpeakingDols = int.Parse(Console.ReadLine());
            int countTedyBears = int.Parse(Console.ReadLine());
            int countMinions = int.Parse(Console.ReadLine());
            int countTruks = int.Parse(Console.ReadLine());

            double puzzle = 2.60;
            double doll = 3;
            double tedy = 4.10;
            double minions = 8.20;
            double truck = 2;

            double sum = countPuzzle * puzzle + countSpeakingDols * doll + countTedyBears * tedy + countMinions * minions
               + countTruks * truck;
            int numberToys = countPuzzle + countSpeakingDols + countTedyBears + countMinions + countTruks;
            if (numberToys >=50)
            {
                double discount = sum * 0.25;
                sum = sum - discount;
            }
            double rentaForShop = sum * 0.10;
            double profit =Math.Abs (sum - rentaForShop -priceForExcursion);
            if (profit >priceForExcursion)
            {
                Console.WriteLine($"Yes! {profit:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {profit:f2} lv needed.");
            }
            
            
          

        }
    }
    
}
