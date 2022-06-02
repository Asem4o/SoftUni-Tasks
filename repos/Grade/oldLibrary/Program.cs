using System;

namespace oldLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            string exampleBook = "";
            bool foundBook = false;
            int counter = 0;
            while (foundBook ==false)
            {
                counter++;
                exampleBook = Console.ReadLine();
                if (exampleBook == "No More Books")
                {
                    break;
                }
                if (book == exampleBook)
                {
                    foundBook = true;
                }
         
            }
            if (foundBook)
            {
                Console.WriteLine($"You checked {counter-1} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {counter -1} books.");
            }
        }
    }
}
