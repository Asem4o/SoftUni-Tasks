using System;

namespace excellentResult1
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number < 5.50 && number > 6)
            {
                Console.WriteLine("excelent");
            }
        }
    }
}
