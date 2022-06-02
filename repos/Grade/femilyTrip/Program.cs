using System;

namespace femilyTrip
{
    class Program
    {
        static void Main(string[] args)
        //input•	Бюджетът, с който разполагат – реално число в интервала [1.00 … 10000.00]
        // Брой нощувки – цяло число в интервала[0 … 1000]
        //	Цена за нощувка – реално число в интервала[1.00 … 500.00]
        //	Процент за допълнителни разходи – цяло число в интервала[0 … 100]

        {
            double budget = double.Parse(Console.ReadLine());
            int countNights = int.Parse(Console.ReadLine());
            double priceForNights = double.Parse(Console.ReadLine());
            int procent = int.Parse(Console.ReadLine());
            double discount = 0;
            if (countNights >7)
            {
                discount = priceForNights * 0.05;
                priceForNights -= discount;
  
            }
            priceForNights = priceForNights * countNights;
            double budget1 = budget * procent / 100;
            double finalSum = priceForNights + budget1;
            Console.WriteLine(finalSum);
            if (finalSum<=budget)
            {
                finalSum = budget - finalSum;
                Console.WriteLine($"Ivanovi will be left with {finalSum:f2} leva after vacation.");
            }
            else
            {
                finalSum = finalSum - budget;
                Console.WriteLine($"{finalSum:f2} leva needed.");
            }
          
        }
    }
}
