using System;

namespace _05._Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodInKg = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int totalFood = 0;
            int foodInGr = 0;
            foodInKg *= 1000;
            while (input != "Adopted")
            {
                foodInGr = int.Parse(input);
                totalFood += foodInGr;
                input = Console.ReadLine();
            }
            if (foodInKg >= totalFood)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInKg - totalFood} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {totalFood - foodInKg } grams more.");
            }
        }
    }
}
