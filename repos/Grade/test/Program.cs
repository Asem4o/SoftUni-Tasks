using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int lenghtOfWord = text.Length;
            for (int index = 0; index <=lenghtOfWord -1; index++)
            {
                Console.WriteLine($"{text[index]}");
            }
            

        }
    }
}
