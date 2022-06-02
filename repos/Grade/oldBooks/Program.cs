using System;

namespace oldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string targetBook = Console.ReadLine();
            Boolean isBookFound = false;
            int count = 0;
            while (isBookFound == false)
            {
                string input = Console.ReadLine();
                count++;
                if (input == "No More Books")
                {
                    break;
                }
                if (input == targetBook)
                {
                    isBookFound = true;
                }
            }
            if (isBookFound)
            {
                Console.WriteLine($"You checked {count - 1} books and found it.");
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {count -1} books.");
            }
           
        }
    }
}
