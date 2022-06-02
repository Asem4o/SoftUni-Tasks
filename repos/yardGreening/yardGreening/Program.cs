using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yardGreening
{
    class Program
    {
        static void Main(string[] args)
        {
            double sqareMetars = double.Parse(Console.ReadLine());
            double priceOfSqreMetars = sqareMetars * 7.61;
            double discount =  0.18 * priceOfSqreMetars;
            double finalPrice = priceOfSqreMetars - discount;
            Console.WriteLine($"The final price is: {finalPrice} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}
