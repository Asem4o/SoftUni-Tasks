using System;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int couter = int.Parse(Console.ReadLine());

            int digit = 0;
            for (int i = 1; i <=couter; i++)
            {
                int sum = 0;
                i digit = i;
                while (digit !=0)
                {
                    sum += digit % 10;
                    digit = digit / 10;
                }
                if (sum == 5 || sum == 7 || sum ==11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
            
        }
    }
}
