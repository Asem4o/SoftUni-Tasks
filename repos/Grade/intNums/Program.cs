using System;

namespace intNums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int max = int.MaxValue;
            int min = int.MinValue;
            for (int i = 0; i < n; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (max>num)
                {
                    max = num;
                }
                if (min <num)
                {
                    min = num;
                }
            }
            Console.WriteLine($"Max number: {min}");
            Console.WriteLine($"Min number: {max}");
        }
    }
}
