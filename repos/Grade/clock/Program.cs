using System;

namespace clock
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int days = 1; days <= 30; days++)
            {
                for (int hour = 0; hour <= 23; hour++)
                {
                    for (int min = 0; min <= 59; min++)
                    {
                        for (int sec = 0; sec <= 59; sec++)
                        {
                            Console.WriteLine($"{days}:{hour}:{min}:{sec}");
                        }
                    }
                }

            }
            
        }
    }
}
