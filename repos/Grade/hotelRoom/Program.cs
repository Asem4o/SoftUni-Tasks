using System;

namespace hotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int numberOvernight = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartament = 0;
            double discount = 0;
            if (month== "May" || month == "October")
            {
                studio = 50;
                apartament = 65;
                if (numberOvernight > 7 && numberOvernight <14)
                {

                    studio *= 0.95 * numberOvernight;
                    apartament = apartament * numberOvernight;
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                    return;


                }
                else if (numberOvernight > 14)
                {
                    studio *= 0.70 * numberOvernight;
                    apartament *= 0.90 * numberOvernight;
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                    return;
                } 

                studio = studio * numberOvernight;
                apartament = apartament * numberOvernight;
                Console.WriteLine($"Apartment: {apartament:f2} lv.");
                Console.WriteLine($"Studio: {studio:f2} lv.");

            }
            if (month == "June" || month == "September")
            {
                studio = 75.20;
                apartament = 68.70;
                if (numberOvernight >14)
                {

                    studio *= 0.80 * numberOvernight;
                    apartament *= 0.90 * numberOvernight;
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                    return;

                }
                studio = studio * numberOvernight;
                apartament = apartament * numberOvernight;
                Console.WriteLine($"Apartment: {apartament:f2} lv.");
                Console.WriteLine($"Studio: {studio:f2} lv.");


            }
            if (month == "July" || month == "August")
            {
                studio = 76;
                apartament = 77;
                if (numberOvernight > 14)
                {
                    studio = studio * numberOvernight;
                    apartament *= 0.90 * numberOvernight;
                    Console.WriteLine($"Apartment: {apartament:f2} lv.");
                    Console.WriteLine($"Studio: {studio:f2} lv.");
                    return;

                }
                studio = studio * numberOvernight;
                apartament = apartament * numberOvernight;
                Console.WriteLine($"Apartment: {apartament:f2} lv.");
                Console.WriteLine($"Studio: {studio:f2} lv.");


            }

        }
    }
}
