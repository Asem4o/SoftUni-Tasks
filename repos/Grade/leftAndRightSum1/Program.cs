using System;

namespace leftAndRightSum1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int num1 = 0;
            int num2 = 0;
            int count = 0;
            int count1 = 0;
            int dif = 0;
            for (int i = 1; i <=n; i++)
            {
                num1= int.Parse(Console.ReadLine());
                count += num1;
            }
            for (int index = 1; index <=n; index++)
            {
                num2 = int.Parse(Console.ReadLine());
                count1 += num2;
            }
            if (count == count1)
            {
                Console.WriteLine($"Yes, sum = { count}");
            }
            else
            {
                dif = Math.Abs(count - count1);
                Console.WriteLine($"No, diff = { dif}");
            }
        }
    }
}
