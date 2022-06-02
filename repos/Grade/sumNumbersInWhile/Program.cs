using System;

namespace sumNumbersInWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int initionNumbers = int.Parse(Console.ReadLine());
            int sum = 0; 
            while (sum < initionNumbers)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                
            }
            Console.WriteLine(sum);
        }
    }
}
