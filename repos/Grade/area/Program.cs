using System;

namespace area
{
    class Program
    {
        static void Main(string[] args)
        {
            string figura = Console.ReadLine();
            double numberA = double.Parse(Console.ReadLine());
            

            if (figura == "square")
            {
                double area = numberA * numberA;
                Console.WriteLine($"{area:f3}");
            }
            else if (figura == "rectangle")
            {
                double numberB = double.Parse(Console.ReadLine());
                double area = numberA * numberB;
                Console.WriteLine($"{area:f3}");
            }
            else if (figura == "circle")
            {
                double area = (numberA * numberA) * Math.PI;
                Console.WriteLine($"{area:f3}");
            }
            else if (figura == "triangle")
            {
                double numberB = double.Parse(Console.ReadLine());
                double area = (numberA*numberB)*0.5 ;
                Console.WriteLine($"{area:f3}");
            }
        }
    }
}
