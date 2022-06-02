using System;

namespace sumNumbers1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int numTwo = 0;
            int count = 0;
            for (int i = 0; i <num; i++)
            {
                numTwo = int.Parse(Console.ReadLine());
                count += numTwo;
               
               
            }
            Console.WriteLine(count);
        }
    }
}
