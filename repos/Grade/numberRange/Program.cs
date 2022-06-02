using System;

namespace numberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < -1)
            {
                Console.WriteLine("yes");
            }
        }
    }
}
