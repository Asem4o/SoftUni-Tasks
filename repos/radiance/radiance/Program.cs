using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace radiance
{
    class Program
    {
        static void Main(string[] args)
        {
            double radiance = double.Parse(Console.ReadLine());
            double degree = radiance * 180 / Math.PI;
            Console.WriteLine(Math.Round(degree));
        }
    }
}
