using System;

namespace addluggage
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceLuggageAbove = double.Parse(Console.ReadLine());
            double kgLuggage = double.Parse(Console.ReadLine());
            int daysUntilTrip = int.Parse(Console.ReadLine());
            int luggageCount = int.Parse(Console.ReadLine());

            if (kgLuggage < 10)
            {
                priceLuggageAbove = priceLuggageAbove * 0.2;
            }
            else if (kgLuggage >=10 && kgLuggage <=20)
            {
                priceLuggageAbove = priceLuggageAbove * 0.50;
            }
            if (daysUntilTrip >=30)
            {
                priceLuggageAbove = (priceLuggageAbove * 0.10) + priceLuggageAbove;
            }
            else if (daysUntilTrip >=7 && daysUntilTrip <=30)
            {
                priceLuggageAbove = (priceLuggageAbove * 0.15) + priceLuggageAbove;
            }
            else if (daysUntilTrip <7)
            {
                priceLuggageAbove = (priceLuggageAbove * 0.40) + priceLuggageAbove;
            }
            Console.WriteLine($"The total price of bags is: {priceLuggageAbove*luggageCount:f2} lv.");

        }
    }
}
