using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int nNewLine = int.Parse(Console.ReadLine());
            int currentCharInNumbers = 0;
            string emeptyString = "";
            for (int i = 0; i < nNewLine; i++)
            {
                currentCharInNumbers = 0;
                char currentChar = char.Parse(Console.ReadLine());
                currentCharInNumbers += (int)currentChar + key;
                emeptyString += (char)currentCharInNumbers;



            }
            Console.WriteLine($"{emeptyString}");
        }
    }
}
