using System;

namespace toyShops
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceForTrip = double.Parse(Console.ReadLine());
            int numberPuzzle = int.Parse(Console.ReadLine());
            int numberSpeakingDolls = int.Parse(Console.ReadLine());
            int numberTedybears = int.Parse(Console.ReadLine());
            int numberMinions = int.Parse(Console.ReadLine());
            int numbertrucks = int.Parse(Console.ReadLine());

            double puzzle = 2.60;
            double speakingDoll = 3.00;
            double tedybear = 4.10;
            double minion = 8.20;
            double truck = 2.00;

            double sum = numberPuzzle * puzzle + numberSpeakingDolls * speakingDoll
                + numberTedybears * tedybear + numberMinions * minion + numbertrucks * truck;

            int numberToys = numberPuzzle + numberSpeakingDolls + numberTedybears + numberMinions + numbertrucks;

            if (numberToys >50)
            {
               double discount = sum * 0.25;
                sum = sum - discount;
            }
            double renta = sum * 0.10;
            double profit = sum - renta;

             if (profit > priceForTrip)
            {
                profit = profit - priceForTrip;
                Console.WriteLine($"Yes! {profit:f2} lv left.");
            }
            else if (profit < priceForTrip)
            {
                priceForTrip = priceForTrip - profit;
                Console.WriteLine($"Not enough money! {priceForTrip:f2} lv needed.");
            }
            
           

        }
    }
}
