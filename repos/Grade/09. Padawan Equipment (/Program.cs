using System;

namespace _09._Padawan_Equipment__
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double siberPrices = double.Parse(Console.ReadLine());
            double robePrices = double.Parse(Console.ReadLine());
            double beltPrices = double.Parse(Console.ReadLine());
            int countingBelt = students;
            int count = 0;
            double siberPrice = siberPrices * (Math.Ceiling(students * 0.1 + students));
            double robePrice = robePrices * students;
            for (double i = 1; i <= countingBelt; i++)
            {

                if (i % 6 == 0)
                {
                    count += 0;
                    count++;
                }

            }
            students -= count;
            double beltPrice = beltPrices * students;
            double totalPrice = siberPrice + robePrice + beltPrice;
            if (totalPrice <= money)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {totalPrice - money:f2}lv more.");
            }



        }
    }
}
