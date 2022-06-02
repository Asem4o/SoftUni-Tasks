using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int endtChar = int.Parse(Console.ReadLine());
            for (int i = startChar; i <=endtChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
