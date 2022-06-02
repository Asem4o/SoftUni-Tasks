using System;

namespace voleyBall
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int weekends = int.Parse(Console.ReadLine());

            double weekendsForYears = 48;
            double sf = weekendsForYears - weekends;
            double villiage = weekendsForYears - sf;
            sf = sf * 0.75;
            double dayss = holydays * 0.666666667;
            double allGames = sf + villiage + dayss;
            if (year =="leap")
            {
                allGames =Math.Floor( allGames + (allGames * 0.15));
                Console.WriteLine(allGames);
                return;
            }
            allGames = Math.Floor(allGames);
            Console.WriteLine($"{allGames}");

        }
    }
}
