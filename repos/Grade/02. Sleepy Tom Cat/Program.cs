using System;

namespace _02._Sleepy_Tom_Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int restDaysIMinPerDays = 127;
            int workDaysInMinPerDays = 63;
            int yearDays = 365;
            int tomasPlayingHours = 30000;
            int rastingDaysInHours = days * restDaysIMinPerDays;
            int workingDays = yearDays - days;
            int workingDaysInHours = workingDays * workDaysInMinPerDays;
            int allHours = rastingDaysInHours + workingDaysInHours;
            int restHours = tomasPlayingHours - allHours;
            int hours = Math.Abs(restHours / 60);
            int min = Math.Abs(restHours % 60);
            if (tomasPlayingHours > allHours)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{hours} hours and {min} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{hours} hours and {min} minutes more for play");
            }
        }
    }
}
