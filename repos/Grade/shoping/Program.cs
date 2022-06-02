using System;

namespace shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberVideoCards = int.Parse(Console.ReadLine());
            int numberProcessors = int.Parse(Console.ReadLine());
            int numberRam = int.Parse(Console.ReadLine());

            double videoCards = 250;
            double processors = 0;
            double ram= 0;
            double sumForVideoCards = numberVideoCards * videoCards;
            double pricForProcessors = sumForVideoCards * 0.35;
            double sumForProcessors = numberProcessors * pricForProcessors;
            double priceForRam = sumForVideoCards * 0.10;
            double sumForRam = numberRam * priceForRam;
            

            double totalSum =sumForVideoCards + sumForProcessors + sumForRam;

            if (numberVideoCards >numberProcessors)
            {
                double discount = totalSum *0.15;
                totalSum = totalSum - discount;
            }
            if (totalSum<budget)
            {
                budget = budget - totalSum;
                Console.WriteLine($"You have {budget:f2} leva left!");
            }
            else if (totalSum>budget)
            {
                totalSum = totalSum - budget;
                Console.WriteLine($"Not enough money! You need {totalSum:f2} leva more!");
            }
           
          
           
            
        }
    }
}
