using System;

namespace excellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());

            if (number <=6 && number >=5.50)
            {
                Console.WriteLine("excellent");
            }
            else if (number <5.50 && number >=4)
            {
                Console.WriteLine("very good");
            }
            else if (number <4 && number >=3.50)
            {
                Console.WriteLine("good");
            }
            else if (number <3.50 && number >=2.50 )
            {
                Console.WriteLine("middle");
            }
            else if (number <2.5 && number >=2)
            {
                Console.WriteLine("low");
            }
            else
            {
                Console.WriteLine("invalid number");
            }
        }
    }
}
