using System;

namespace fishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgets = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFishers = int.Parse(Console.ReadLine());
            double finalPrice = 0;
            double rentaForBoat = 0;

            if (season == "Spring")
            {
                rentaForBoat = 3000;
                
            }
            else if (season == "Summer" || season =="Autumn")
            {
                rentaForBoat = 4200;
            }
            else
            {
                rentaForBoat = 2600;
            }
            if (numberFishers <=6)
            {
                finalPrice = rentaForBoat - (rentaForBoat * 0.10);
            }
            else if (numberFishers <=11 )
            {
                finalPrice = rentaForBoat - (rentaForBoat * 0.15);
            }
            else
            {
                finalPrice = rentaForBoat - (rentaForBoat * 0.25);
            }

            if (season != "Autumn" && numberFishers % 2==0)//
            {
                finalPrice *= 0.95; //5 % discount
            }
            if (budgets >=finalPrice)
            {
                budgets -= finalPrice;
                Console.WriteLine($"Yes! You have {budgets:f2} leva left.");
            }
            else
            {
                finalPrice -= budgets;
                Console.WriteLine($"Not enough money! You need {finalPrice:f2} leva.");
            }
        }
    }
}
