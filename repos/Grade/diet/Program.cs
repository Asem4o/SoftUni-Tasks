using System;

namespace diet
{
    class Program
    {
        static void Main(string[] args)
        {
            int fatsProcents = int.Parse(Console.ReadLine());
            int proteinsProcents = int.Parse(Console.ReadLine());
            int carboProcents = int.Parse(Console.ReadLine());
            int allCal = int.Parse(Console.ReadLine());
            int waterProcents = int.Parse(Console.ReadLine());

            double oneFats = 9;
            double oneProteins = 4;
            double oneCarbo = 4;

            double allfats = ((fatsProcents * allCal)/100)/oneFats;
            double allProteins = ((proteinsProcents * allCal)/100)/ oneProteins;
            double allCarbo = ((carboProcents * allCal)/100)/ oneCarbo;
            double foodKg = allfats + allProteins + allCarbo;
            double calForOneKgFoods = allCal / foodKg;
            int allProcents = (fatsProcents + proteinsProcents + carboProcents)- waterProcents;
            double gramLEE = (allProcents * calForOneKgFoods)/100;
            Console.WriteLine($"{gramLEE:f4}");

        }
    }
}
