using System;

namespace vacetionBookList
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPagesInCurrentBook = int.Parse(Console.ReadLine());
            int numberList = int.Parse(Console.ReadLine());
            int numberDays = int.Parse(Console.ReadLine());

            int final = (numberPagesInCurrentBook / numberList)/numberDays;
            Console.WriteLine(final);
        }
    }
}
