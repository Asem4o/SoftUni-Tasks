using System;

namespace _06._Foreign_Languages
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input == "USA" || input == "England")
            {
                Console.WriteLine("English ");
            }
            else if (input == "Spain" || input== "Argentina" || input == "Mexico")
            {
                Console.WriteLine("Spanish ");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
