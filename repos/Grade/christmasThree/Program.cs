using System;

namespace christmasTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int whiteSpaceCounter = n;
            int starsCount = 0;
            for (int row = 0; row <=n; row++) 
            {
                 Console.Write(new string (' ',whiteSpaceCounter));
                Console.Write(new string('*',starsCount));
                 Console.Write(" | ");
                Console.Write(new string('*', starsCount));
                Console.WriteLine();
                whiteSpaceCounter--;
                starsCount++;
            }
        }
    }
}
