using System;

namespace everest__
{
    class Program
    {
        static void Main(string[] args)
        {

          
            int firstPeak = 5364;
            int finalPeak = 8848;
            int days = 1;
            while (true) // докато не стигна върха прави еди какво си !
            {
                if (days >5 || firstPeak >= finalPeak)// ако си минал макс дни и макс височина !
                {
                    break;
                }
                string question = Console.ReadLine();
                if (question == "END")
                {
                    break;
                }
                int m = int.Parse(Console.ReadLine());
                firstPeak += m;

                if (question == "Yes")
                {
                    days++;
                } 
            }
            if (firstPeak >=finalPeak)
            {
                Console.WriteLine($"Goal reached for {days} days!");
            }
            else
            {
                Console.WriteLine("Failed!");
                Console.WriteLine(firstPeak);

            }

        }
    }
}
