using System;
using System.Numerics;

namespace _2._From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLine = int.Parse(Console.ReadLine());
            long finalSum = 0;
            for (int i = 0; i <nLine; i++)
            {
                finalSum = 0;
                string[] value = Console.ReadLine().Split(' ');

                long x = long.Parse(value[0]);
                long y = long.Parse(value[1]);
                if (x > y)
                {
                    while (x != 0)
                    {
                        finalSum += x % 10;
                        x /= 10;
                    }                
                }
              
                else 
                {
                    while (y != 0)
                    {
                        finalSum += y % 10;
                        y /= 10;
                    }
                }
                Console.WriteLine(Math.Abs(finalSum));
               
            }
            Console.WriteLine();
        }

    }
}
