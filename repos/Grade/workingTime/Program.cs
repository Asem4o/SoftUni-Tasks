using System;

namespace workingTime
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            string dayOfWeeks = Console.ReadLine();

            switch (dayOfWeeks)
            {
                case "Monday":
                case "Tuesday":
                case "Wednesday":
                case "Thursday":
                case "Friday":
                case "Saturday":
                    if (hours >=10 && hours <=18)
                    {
                        Console.WriteLine("open");
                    }
                    else
                    {
                        Console.WriteLine("closed");
                    }
                    break;
                case "Sunday":
                    Console.WriteLine("closed");
                    break;
                default:
                    break;
            }
        }
    }
}
