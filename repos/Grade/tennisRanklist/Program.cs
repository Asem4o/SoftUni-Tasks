using System;

namespace tennisRanklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int countTurnirs = int.Parse(Console.ReadLine());
            int score = int.Parse(Console.ReadLine());
            string turnir = "";
            double f = 0;
            double w = 0;
            double sf = 0;
            int winner = 0;
            double middlePoints = 0;
            double procent = 0;

            for (int i = 0; i <countTurnirs; i++)
            {
                turnir = Console.ReadLine();
                switch (turnir)
                {
                    case "F":
                        score += 1200;
                        f+= 1200;
                        break;
                    case "W":
                        score += 2000;
                        w += 2000;
                        winner += 1;
                        break;
                    case "SF":
                        score += 720;
                        sf += 720;
                        break;
                    default:
                        break;
                }
            }
            middlePoints =(f + w + sf) / countTurnirs;
            procent = (1.0* winner / countTurnirs) * 100;
            Console.WriteLine($"Final points: {score}");
            Console.WriteLine($"Average points: {Math.Floor( middlePoints)}");
            Console.WriteLine($"{procent:f2}%");



        }
    }
}