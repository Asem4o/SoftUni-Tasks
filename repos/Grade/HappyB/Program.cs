using System;

namespace HappyB
{
    class Program
    {
        static void Main(string[] args)
        {
            double rent = double.Parse(Console.ReadLine());
            double priceForCacke = rent * 0.2;
            double priceForDrinks = priceForCacke - (priceForCacke * 0.45);
            double priceForAnimators = (rent * 1) / 3;
            double finalSum = rent + priceForCacke + priceForDrinks + priceForAnimators;
            Console.WriteLine(finalSum);


        }
    }
}
