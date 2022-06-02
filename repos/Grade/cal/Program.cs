using System;

namespace cal
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int expire = int.Parse(Console.ReadLine());
            double GPR = double.Parse(Console.ReadLine());

            double sum = depositSum + GPR * ((depositSum * GPR) / 12);
            Console.WriteLine($"{sum:f2}");
        }
    }
}
