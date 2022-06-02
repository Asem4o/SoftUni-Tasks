using System;

namespace _4._Back_in_30_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            min += 30;
            if (min >=60)
            {
                min -=60;
                hour++;
            }
            if (hour ==24)
            {
                hour = 0;
            }
            Console.WriteLine($"{hour}:{min:d2}");
        }
    }
}
