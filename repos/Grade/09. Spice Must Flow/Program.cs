using System;

namespace _09._Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int input =int.Parse(Console.ReadLine());
            const int CONSUME_BY_WORKARS = 26;
            const int YELD_DROPS = 10;
            const int DAYS_MINE = 100;
            int totalConsume = 0;
            int counter = 0;
           
            while (input >=DAYS_MINE)
            {
                totalConsume += input - CONSUME_BY_WORKARS;
                input -= YELD_DROPS;
                counter++;
                if (input < DAYS_MINE)
                {
                    totalConsume -= CONSUME_BY_WORKARS;
                }
            }
            
            Console.WriteLine(counter);
            Console.WriteLine(totalConsume);
        }
    }
}
