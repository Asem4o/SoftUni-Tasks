using System;

namespace cacke
{
    class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());
            int totalPeaces = sideA * sideB;
            bool hasCacke = true;

            while (hasCacke)
            {
                string input = Console.ReadLine();
                if (input =="STOP")
                {
                    break;
                }
                int peaces = int.Parse(input);
                totalPeaces -= peaces;
                if (totalPeaces <0 )
                {
                    hasCacke = false;
                   
                }

            }
            if (hasCacke )
            {
                Console.WriteLine($"{totalPeaces} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(totalPeaces)} pieces more.");
            }
        }
    }
}
