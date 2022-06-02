using System;

namespace _05._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double freeSpace = double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double suitCase = 0;
            double counter = 0;

            while (input != "End")
            {
                suitCase = double.Parse(input);
               
                
                counter++;
                if (counter % 3 == 0)
                {
                    suitCase += suitCase * 0.1;
                }
                if (freeSpace <= suitCase)
                {
                    counter--;
                    break;
                }
                freeSpace -= suitCase;
                input = Console.ReadLine();

            }
            if (input == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }
            else
            {
                Console.WriteLine("No more space!");
            }
            Console.WriteLine($"Statistic: {counter} suitcases loaded.");

        }
    }
}
