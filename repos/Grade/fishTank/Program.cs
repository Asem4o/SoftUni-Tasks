using System;

namespace fishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lendInSm = int.Parse(Console.ReadLine());
            int widhInSm = int.Parse(Console.ReadLine());
            int highInSm = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            double areaOfTank = lendInSm * widhInSm * highInSm;
            double areaInLiturs = areaOfTank / 1000;
            double teakingArea = procent /100;
            double neededLiturs = areaInLiturs * (1 - teakingArea);
            Console.WriteLine(neededLiturs);

        }
    }
}
