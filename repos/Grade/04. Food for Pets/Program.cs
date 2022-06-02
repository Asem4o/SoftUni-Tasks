using System;

namespace _04._Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double food = double.Parse(Console.ReadLine());
            int dogFoods = 0;
            int catFoods = 0;
            double biscuite = 0;
            double foodForDog = 0;
            double foodForCat = 0;
            double allfood = 0;
            double allfoodForDay = 0;
            double allbiskvits= 0;
        
            for (int i = 1; i <= num; i++)
            {
               
                dogFoods = int.Parse(Console.ReadLine());
                catFoods = int.Parse(Console.ReadLine());
                foodForDog += dogFoods;
                foodForCat += catFoods;
                allfood = foodForDog + foodForCat;
                allfoodForDay = dogFoods + catFoods;
                if (i % 3 == 0)
                {
                    biscuite = allfoodForDay * 0.1;
                    allbiskvits += biscuite;
                }
                  
            if (food <=allfood)
            {
                allfood = food;
                break;
            }

            }
            foodForDog = (foodForDog / allfood) * 100;
            foodForCat = (foodForCat / allfood) * 100;
            food = (allfood / food) * 100;
            Console.WriteLine($"Total eaten biscuits: {Math.Round(allbiskvits)}gr.");
            Console.WriteLine($"{food:f2}% of the food has been eaten.");
            Console.WriteLine($"{foodForDog:f2}% eaten from the dog.");
            Console.WriteLine($"{foodForCat:f2}% eaten from the cat.");
        }

    }
}
