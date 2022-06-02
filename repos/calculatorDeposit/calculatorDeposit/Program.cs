using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorDeposit
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositSum = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double gpr = double.Parse(Console.ReadLine());

            double sum   = depositSum + gpr;

            Console.WriteLine(interest);



        }
    }
}
