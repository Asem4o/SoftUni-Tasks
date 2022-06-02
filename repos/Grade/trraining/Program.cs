using System;

namespace trraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double km = double.Parse(Console.ReadLine());
            int pr = 0;
            double pr1 = 0;
            double pr2 = 0;
            double pr3 = 0;
            double pr4 = km;
            double pr5 = 0;
            double pr6 = 0;
            for (int i = 0; i < days; i++)
            {
                pr = int.Parse(Console.ReadLine());
                pr1 = km * pr / 100;
                pr2 = km + pr1;
                km +=pr1;
                pr3+= pr2;
            }
            pr5 = pr3 + pr4;
            if (pr5 < 1000)
            {
                pr6 =Math.Ceiling( 1000 - pr5);
                Console.WriteLine($"Sorry Mrs. Ivanova, you need to run {pr6} more kilometers");
            }
            else
            {
                pr6 =Math.Ceiling( pr5 - 1000);
                Console.WriteLine($"You've done a great job running {pr6} more   kilometers!");
            }
            
        }

    }
}
