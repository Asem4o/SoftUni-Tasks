using System;

namespace gudzillaVsKinKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberStatists = int.Parse(Console.ReadLine());
            double priceForStatists = double.Parse(Console.ReadLine());

            double totalPriceForCloth = numberStatists * priceForStatists;
            budget -= budget * 0.10;

            if (numberStatists > 150 )
            {

                totalPriceForCloth -= totalPriceForCloth * 0.10;
                  
            }
            budget -= totalPriceForCloth;

             if (budget >0 )
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget:f2} leva left.");
            }
            else
            {
                Console.WriteLine(" Not enough money!");
                Console.WriteLine($"Wingard needs {Math.Abs(budget):f2} leva more.");
            }


        }
    }
}
