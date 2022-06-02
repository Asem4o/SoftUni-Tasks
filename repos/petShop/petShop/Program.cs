using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfDogs = int.Parse(Console.ReadLine());
            int countOfOtherAnimals = int.Parse(Console.ReadLine());
            double finalSum = (countOfDogs * 2.5) + (countOfOtherAnimals * 4);
            Console.WriteLine($"{finalSum} lv.");



        }
    }
}
