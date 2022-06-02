using System;

namespace leftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            double sum1 = 0;
            

            for (int i= 1; i <= n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                sum += a;

            }
            for (int i = 1; i <= n; i++)
            {
                int b = int.Parse(Console.ReadLine());
                sum1 += b;

            }
            if (sum==sum1)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                double dif =Math.Abs( sum - sum1);
                Console.WriteLine($"No, diff = {dif}");
            }
           
          
            
        }
       
    }
}
