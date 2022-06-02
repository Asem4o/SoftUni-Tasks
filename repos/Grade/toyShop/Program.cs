using System;

namespace toyShop
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
        }
    }
}
