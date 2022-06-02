using System;

namespace scolarShip
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double middleGrade = double.Parse(Console.ReadLine());
            double minimymSolary = double.Parse(Console.ReadLine());
            double socialScolar = minimymSolary * 0.35;
            double excelentlScolar = middleGrade * 25;             
            if (middleGrade >=5.50)
            {
                if (excelentlScolar >=socialScolar  || income > minimymSolary )
                {
                    Console.WriteLine($"You get a scholarship for excellent results {excelentlScolar} BGN");
                }
                else
                {
                    Console.WriteLine($"You get a Social scholarship {socialScolar} BGN");
                }
            }
            else  if (income < minimymSolary && middleGrade > 4.50)
            {
                Console.WriteLine($"You get a Social scholarship {socialScolar} BGN");
            }
            else
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
        }
    }
}
