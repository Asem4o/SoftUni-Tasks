using System;

namespace Cinema_work
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());
            double income = 0;
            if (type == "Premiere")
            {
                income = rows * colum * 12;
            }
            else if (type == "Normal")
            {
                income = rows * colum * 7.5;
            }
            else if (type == "Discount")
            {
                income = rows * colum * 5.0;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
