using System;

namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalPoints = 0;
            while (true)
            {
                string ballColor = Console.ReadLine();
                int points = ballColor == "red" ? 5 : ballColor == "orange" ? 10 : ballColor == "yellow" ? 15 : ballColor == "white" ? 20 : ballColor =="black"?-1:0;
                totalPoints = points == -1 ? totalPoints / 2 : totalPoints += points;
                Console.WriteLine(totalPoints);
            }
            
        }
    }
}
