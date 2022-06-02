using System;

namespace balls1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int count = 0;
            int points = 0;
            int redballs = 0;
            int orangeBalls = 0;
            int yellowBalls = 0;
            int whiteBalls = 0;
            int blackBalls = 0;
            int redcount = 0;
            int orangecount = 0;
            int yellowcount = 0;
            int whitecounts = 0;
            int othercolor = 0;
            int devidedcolor = 0;

            while (n >count)
            {
                count++;
                string input = Console.ReadLine();
                if (input !="red" && input !="orange" && input !="yellow" && input != "white" && input != "black")
                {
                    othercolor++;
                }
                switch (input)
                {
                    case "red":
                        redcount++;
                        redballs = 5;
                        points += redballs;
                        break;
                    case "orange":
                        orangecount++;
                        orangeBalls = 10;
                        points += orangeBalls;
                        break;
                    case "yellow":
                        yellowcount++;
                        yellowBalls = 15;
                        points += yellowBalls;
                        break;
                    case "white":
                        whitecounts++;  
                        whiteBalls = 20;
                        points += whiteBalls;
                        break;
                    case "black":
                        devidedcolor++;
                        blackBalls = points / 2;
                        points = blackBalls;
                        break;
                    default:
                        break;
                }
               
            }
            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redcount}");
            Console.WriteLine($"Orange balls: {orangecount}");
            Console.WriteLine($"Yellow balls: {yellowcount}");
            Console.WriteLine($"White balls: {whitecounts}");
            Console.WriteLine($"Other colors picked: {othercolor}");
            Console.WriteLine($"Divides from black balls: {devidedcolor}");
        }
    }
}
