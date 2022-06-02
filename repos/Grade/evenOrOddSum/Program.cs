using System;

namespace evenOrOddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num = 0;
            int sum = 0;
            int sum1 = 0;
            int dif = 0;
            for (int i = 0; i <n; i++)
            {
               num = int.Parse(Console.ReadLine());
                if (i %2==0)
                {
                    sum += num;
                }
                else
                {
                    sum1 += num;
                }
            }
            if (sum==sum1)
            {
                Console.WriteLine("yes");
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                dif = Math.Abs(sum - sum1);
                Console.WriteLine("no");
                Console.WriteLine($"Diff = {dif}");

            }
        }
    }
}
