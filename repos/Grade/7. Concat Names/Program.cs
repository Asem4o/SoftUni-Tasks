using System;

namespace _7._Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondtName = Console.ReadLine();
            string symbol = Console.ReadLine();
            Console.WriteLine($"{firstName}{symbol}{secondtName}");
        }
    }
}
