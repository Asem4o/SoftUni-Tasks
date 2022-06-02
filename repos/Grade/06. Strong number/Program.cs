using System;

namespace _06._Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int strongNumber = int.Parse(Console.ReadLine());
            int coppyOfStrongNumber = strongNumber;
            int sum = 0;
            while (strongNumber != 0)
            {
                int factorielNumber = 1;
                int currentNumber = strongNumber % 10;
                strongNumber /= 10;
                for (int i = 2; i <= currentNumber; i++)
                {
                    factorielNumber *= i;
                }
                sum += factorielNumber;
            }
            Console.WriteLine(sum == coppyOfStrongNumber ? "yes" : "no");


        }
    }
}
