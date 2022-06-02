using System;

namespace _05._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string location = "";
            string placeForResting = "";
            if (budget <= 1000)
            {
                placeForResting = "Camp";
                if (season == "Summer")
                {
                    budget = budget * 0.65;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    budget = budget * 0.45;
                    location = "Morocco";
                }
            }
            else if (budget > 1000 && budget <= 3000)
            {
                placeForResting = "Hut";
                if (season == "Summer")
                {
                    budget = budget * 0.80;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    budget = budget * 0.60;
                    location = "Morocco";
                }
            }
            else
            {
                placeForResting = "Hotel";
                if (season == "Summer")
                {
                    budget = budget * 0.90;
                    location = "Alaska";
                }
                else if (season == "Winter")
                {
                    budget = budget * 0.90;
                    location = "Morocco";
                }
            }
            Console.WriteLine($"{location} - {placeForResting} - {budget:f2}");
        }
    }
}