using System;

namespace _01._Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] currentDay = {"Monday", "Tuesday", "Wednesday", "Thursday","Friday","Saturday","Sunday", };
            Console.WriteLine(dayOfWeek >=1 && dayOfWeek <=currentDay.Length? currentDay[dayOfWeek-1]:"Invalid day!");

        }
    }
}
