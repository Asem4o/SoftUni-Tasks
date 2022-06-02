using System;

namespace _01._SoftUni_Reception
{
    class Program
    {
        static void Main(string[] args)
        {
            int eachEmployee = 0;
            int studentsPerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                eachEmployee =int.Parse(Console.ReadLine());
                studentsPerHour += eachEmployee;
            }
            int studentsCount = int.Parse(Console.ReadLine());
            int hours = 0;
            
            while (studentsCount >0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;

                }
                studentsCount -= studentsPerHour;


            }
            Console.WriteLine($"Time needed: {hours }h.");
        }
    }
}
