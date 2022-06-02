using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int people = int.Parse(Console.ReadLine());
            string typeOfStudents = Console.ReadLine();
            string day = Console.ReadLine();
            double price = 0;
            if (typeOfStudents == "Students")
            {
                if (day == "Friday")
                {
                    price = people * 8.45;
                }
                else if (day == "Saturday")
                {
                    price = people * 9.80;
                }
                else if (day == "Sunday")
                {
                    price = people * 10.46;
                }
                if (people >= 30)
                {
                    price *= 0.85;
                }
            }
            if (typeOfStudents == "Business")
            {
                if (day == "Friday")
                {
                    price = people * 10.90;
                }
                else if (day == "Saturday")
                {
                    price = people * 15.60;
                }
                else if (day == "Sunday")
                {
                    price = people * 16;
                }
                if (people >= 100)
                {
                    price -= price / people * 10;
                }
            }
            if (typeOfStudents == "Regular")
            {
                if (day == "Friday")
                {
                    price = people * 15;
                }
                else if (day == "Saturday")
                {
                    price = people * 20;
                }
                else if (day == "Sunday")
                {
                    price = people * 22.50;
                }
                if (people >= 10 && people <= 20)
                {
                    price *= 0.95;
                }
            }
            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
