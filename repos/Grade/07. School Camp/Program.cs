using System;

namespace _07._School_Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numOfNights = int.Parse(Console.ReadLine());
            double price = 0;
            string sport = "";
            if (season == "Winter")
            {
                if (group == "boys")
                {
                    price = 9.60;
                    sport = "Judo";
                }
                else if (group == "girls")
                {
                    price = 9.60;
                    sport = "Gymnastics";
                }
                else if (group == "mixed")
                {
                    price = 10.0;
                    sport = "Ski";
                }
            }
            else if (season == "Spring")
            {
                if (group == "boys")
                {
                    price = 7.20;
                    sport = "Tennis";
                }
                else if (group == "girls")
                {
                    price = 7.20;
                    sport = "Athletics";
                }
                else if (group == "mixed")
                {
                    price = 9.50;
                    sport = "Cycling";
                }
            }
            else if (season == "Summer")
            {
                if (group == "boys")
                {
                    price = 15;
                    sport = "Football";
                }
                else if (group == "girls")
                {
                    price = 15;
                    sport = "Volleyball";
                }
                else if (group == "mixed")
                {
                    price = 20;
                    sport = "Swimming";
                }
            }
            if (numberOfStudents >= 10 && numberOfStudents < 20)
            {
                price *= 0.95;
            }
            else if (numberOfStudents >= 20 && numberOfStudents <50)
            {
                price *= 0.85;
            }
            else if (numberOfStudents >=50)
            {
                price *= 0.5;
            }
            price = numberOfStudents * price * numOfNights;
            Console.WriteLine($"{sport} {price:f2} lv.");
        }
    }
}
