using System;

namespace halfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = 0;

            for (int i = 0; i < n; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber;

                if (currentNumber > max)
                {
                    max = currentNumber;
                }

            }
            if (sum - max == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else
            {
                // sum = 4 2 1 =7
                // sum = 4 - (7 - 4)=4 -3=1 
                int dif = Math.Abs(max - (sum - max));
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {dif}");

                /// if (dif<0)
                //  {
                //      dif = dif * -1;
                //}
                //alternativa
            }
        }
    }
}
