using System;

namespace jorney
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double summer = 0;
            double winter = 0;

            if (season == "summer")
            {
                if (budget <=100)
                {
                    summer =Math.Abs( summer - (budget * 0.30));
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {summer:f2}");
                }
                else if (budget <=1000)
                {
                    summer =Math.Abs( summer - (budget * 0.40));
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {summer:f2}");

                }
                
            }
            else if (season == "winter")
            {
                if (budget <=100)
                {
                    winter = Math.Abs(winter - (budget * 0.70));
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {winter:f2}");
                }
                else if (budget <=1000)
                {
                    winter = Math.Abs(winter - (budget * 0.80));
                    Console.WriteLine("Somewhere in Balkans ");
                    Console.WriteLine($"Hotel - {winter:f2}");

                }
            }
            if (budget >1000)
            {

                budget = budget * 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget:f2}");
            }

        }
    }
}
