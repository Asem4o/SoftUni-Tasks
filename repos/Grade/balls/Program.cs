using System;

namespace balls
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int redBall = 0;
            int orange = 0;
            int yellow= 0;
            int white = 0;
            int black = 0;
            string balls = Console.ReadLine();


            while (balls != "s")
            {
                int n = int.Parse(Console.ReadLine());
                balls = Console.ReadLine();

                switch (balls)
                {
                    case "red":
                        redBall = 5;
                        count += redBall;
                        break;
                    case "orange":
                        orange = 10;
                        count += orange;
                        break;
                    case "yellow":
                        yellow = 15;
                        count += yellow;
                        break;
                    case "white":
                        white = 20;
                        count += white;
                        break;
                    case "black":
                        black = count / 2;
                        count += black;
                        break;
                    default:
                        break;
                }
                

            }
            
        }
    }
}
