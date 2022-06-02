using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            string fifure = (Console.ReadLine());
            double number = double.Parse(Console.ReadLine());



            if (fifure == "sqare")
            {
                number = number * number;
                Console.WriteLine(number);
            }
            else if (fifure == "rectangler")
            {
                double lend = double.Parse(Console.ReadLine());
                double area = number * lend;
                Console.WriteLine(area);
            }
            else if (fifure == "circle")
            {
                double circlearea = (number * number) * 3.1415926535897931;
                Console.WriteLine(circlearea);
            }
            else if (fifure == "triangle")
            {
                double lend = double.Parse(Console.ReadLine());
                double area = (number * lend) / 2;
                Console.WriteLine(area);


            }
        }

    }



}



