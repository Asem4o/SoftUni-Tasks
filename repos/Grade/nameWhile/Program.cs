using System;

namespace nameWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            while (name !="stop")
            {
                name = Console.ReadLine();
            }
        }
    }
}
