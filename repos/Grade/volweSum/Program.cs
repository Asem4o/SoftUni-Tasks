using System;

namespace volweSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string letters = Console.ReadLine();
            int wordToLanght = letters.Length;
            int count = 0;
            for (int index = 0; index <=wordToLanght -1; index++)
            {
                char currentChar = letters[index];
                switch (currentChar)
                {
                    case 'a':
                        count += 1;
                        break;
                    case 'e':
                        count +=2;
                        break;
                    case 'i':
                        count +=3;
                        break;
                    case 'o':
                        count +=4;
                        break;
                    case 'u':
                        count +=5;
                        break;
                    default:
                        break;
                }
                
            }
            Console.WriteLine(count);
        }
    }
}
