using System;

namespace evenPowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            for (int power = 0; power <=a; power+=2)
            {
                Console.WriteLine(Math.Pow(2, power));

            }
        }
    }
}
