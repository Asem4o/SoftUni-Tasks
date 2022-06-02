using System;

namespace cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int coloms = int.Parse(Console.ReadLine());

            double income = 0;

            if (type == "Premiere")
            {
                income = rows * coloms * 12.00;
            }
            else if (type == "Normal")
            {
                income = rows * coloms * 7.50;
            }
            else if (type == "Discount")
            {
                income = rows * coloms * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
       
       
    }
}
