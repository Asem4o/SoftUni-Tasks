using System;

namespace depositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int turmForDeposit = int.Parse(Console.ReadLine());
            double gdp = double.Parse(Console.ReadLine());

            double interest = ((depositSum * gdp)/100)/12;

            double sum = depositSum+turmForDeposit *interest;
                Console.WriteLine($"{sum:f2}");
        }
    }
}
