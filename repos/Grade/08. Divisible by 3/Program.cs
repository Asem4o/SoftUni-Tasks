using System;

namespace _08._Divisible_by_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int number = 0;
            for (int i = 0; i <n; i++)
            {
                number = 1 + (2 * i);
                counter += number;
                Console.WriteLine(number);
            }
            Console.WriteLine($"Sum: {counter}");
        }
    }
}
