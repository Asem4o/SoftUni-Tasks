using System;

namespace justTakeAnotherPill_
{
    class Program
    {
        static void Main(string[] args)
        {
            int himikalkipaket = int.Parse(Console.ReadLine());
            int markeripaket = int.Parse(Console.ReadLine());
            int litripreparat    = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double himikalki = 5.80;
            double markerit = 7.20;
            double preparat = 1.20;
            double sumhimikalki = himikalkipaket * himikalki;
            double summarkeri = markeripaket * markerit;
            double sumpreparata = litripreparat * preparat;
            double allMaterials = sumhimikalki + summarkeri + sumpreparata;
            double finalsum = allMaterials - (allMaterials * discount / 100);
            Console.WriteLine($"{finalsum:}");
            int a = 4;
            int b = 4;
            if (a ==4 && b==4)
            {
                Console.WriteLine();
            }


        }
    }
}
