using System;

namespace _01._Black_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int dailyPlunder = int.Parse(Console.ReadLine());
            double expectedPlunder = double.Parse(Console.ReadLine());
            double ganePlumber = 0;
            for (int i = 1; i <= days; i++)
            {
                ganePlumber +=dailyPlunder;
                if (i % 3 == 0)
                {
                    ganePlumber += dailyPlunder * 0.5;

                }
                if (i % 5 == 0)
                {
                    ganePlumber *= 0.7;
                }

            }
            if (ganePlumber >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {ganePlumber:f2} plunder gained.");
            }
            else
            {

                Console.WriteLine($"Collected only { ganePlumber / expectedPlunder * 100:f2}% of the plunder.");
            }
            
        }
    }
}
