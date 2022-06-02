using System;

namespace _09._Numbers_from_1_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            double n = double.Parse(Console.ReadLine());
            while (!exit)
            {

                if (n >= 0)
                {
                    Console.WriteLine($"Result: {n * 2:f2}");
                }
                else
                {
                    Console.WriteLine("Negative number!");
                    exit = true;
                    break;
                }
                n = double.Parse(Console.ReadLine());
            }

        }
    }
}
