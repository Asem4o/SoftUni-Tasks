using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMax = double.MinValue;
            double oddMin = double.MaxValue;
            double evenSum = 0;
            double evenMax = double.MinValue;
            double evenMin = double.MaxValue;

            for (int i = 1; i <= count; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += number;
                    if (evenMax < number)
                    {
                        evenMax = number;
                    }
                    if (evenMin > number)
                    {
                        evenMin = number;
                    }
                }
                else
                {
                    oddSum += number;
                    if (oddMax < number)
                    {
                        oddMax = number;
                    }
                    if (oddMin > number)
                    {
                        oddMin = number;
                    }
                }
            }
            Console.WriteLine($"OddSum ={oddSum},");
            if (oddSum == 0)
            {
                Console.WriteLine($"OddMin =No,");
                Console.WriteLine($"OddMax =No,");
            }
            else
            {
                Console.WriteLine($"OddMin ={oddMin},");
                Console.WriteLine($"OddMax ={oddMax},");
            }
            Console.WriteLine($"EvenSum ={evenSum},");
            if (evenSum == 0)
            {
                Console.WriteLine($"EvenMin =No,");
                Console.WriteLine($"EvenMax =No,");
            }
            else
            {
                Console.WriteLine($"EvenMin ={evenMin},");
                Console.WriteLine($"EvenMax ={evenMax}");
            }

        }
    }
}
