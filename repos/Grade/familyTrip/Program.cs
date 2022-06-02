using System;

namespace familyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int overnight = int.Parse(Console.ReadLine());
            double priceForOneNight = double.Parse(Console.ReadLine());
            int procentForCosts = int.Parse(Console.ReadLine());
            double discount = 0;
           

            if (overnight > 7)
            {
                discount = priceForOneNight * 0.05;
            }
            double priceForSleep = (priceForOneNight - discount) * overnight;
            double procentige = (budget * procentForCosts) / 100;
            double wholeSum = priceForSleep + procentige;
            if (wholeSum <= budget)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - wholeSum:f2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{wholeSum - budget:f2} leva needed.");
            }
           
        }
             
    }
    
    
}
