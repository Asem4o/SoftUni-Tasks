using System;

namespace passwordsAnumius
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string correctPassword = Console.ReadLine();
            string input = Console.ReadLine();


            while (input !=correctPassword)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
