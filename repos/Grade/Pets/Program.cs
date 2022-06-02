using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            double foodForDogInKg = double.Parse(Console.ReadLine());
            double foodForCatInKg = double.Parse(Console.ReadLine());
            double foodForTurtleInGr = double.Parse(Console.ReadLine());
            
            double needFoodForDog = day * foodForDogInKg;
            double needFoodForCat = day * foodForCatInKg;
            double needFoodForTurtle =(day * foodForTurtleInGr)/1000;
            double wholeFood = needFoodForDog + needFoodForCat + needFoodForTurtle;
            
            if (wholeFood <food)
            {
                food -= wholeFood;
                Console.WriteLine($"{Math.Floor(food)} kilos of food left.");
            }
            else
            {
                food =Math.Ceiling(wholeFood-food);
                Console.WriteLine($"{food} more kilos of food are needed.");
            }
        }
    }
}
