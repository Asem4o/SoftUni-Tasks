using System;

namespace skiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int holyDays = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int dayforSleep = holyDays - 1;

            double roomForOnePerson = 18.00;
            double apartment = 25.00;
            double presidentApartment = 35.00;

            if (typeOfRoom == "room for one person")
            {
                roomForOnePerson = roomForOnePerson * dayforSleep;
                if (evaluation == "positive")
                {
                    roomForOnePerson = roomForOnePerson + (roomForOnePerson * 0.25);
                    Console.WriteLine($"{(roomForOnePerson.ToString("0.00"))}");

                }
                else if (evaluation =="negative")
                {
                    roomForOnePerson = roomForOnePerson - (roomForOnePerson * 0.10);
                    Console.WriteLine($"{(roomForOnePerson.ToString("0.00"))}");
                }
                
            }
            if (typeOfRoom == "apartment")
            {
                if (holyDays < 10)
                {
                    apartment = apartment * dayforSleep;
                    apartment = apartment - (apartment * 0.30);
                   
                }
                else if (holyDays >10 && holyDays < 15)
                {
                    apartment = apartment * dayforSleep;
                    apartment = apartment - (apartment * 0.35);
                }
                else if (holyDays > 15)
                {
                    apartment = apartment * dayforSleep;
                    apartment = apartment - (apartment * 0.50);
                }
                if (evaluation == "positive")
                {
                    apartment =apartment + (apartment * 0.25) ;
                

                    Console.WriteLine($"{(apartment.ToString("0.00"))}");
                    return;
                }
                else if (evaluation=="negative")
                {
                    apartment = apartment - (apartment * 0.10);
                    Console.WriteLine($"{(apartment.ToString("0.00"))}");
                    return;
                }
            }
            if (typeOfRoom == "president apartment")
            {
                if (holyDays < 10)
                {
                    presidentApartment = presidentApartment * dayforSleep;
                    presidentApartment = presidentApartment - (presidentApartment * 0.10);

                }
                else if (holyDays > 10 && holyDays < 15)
                {
                    presidentApartment = presidentApartment * dayforSleep;
                    presidentApartment = presidentApartment - (presidentApartment * 0.15);
                }
                else if (holyDays > 15)
                {
                    presidentApartment = presidentApartment * dayforSleep;
                    presidentApartment = presidentApartment - (presidentApartment * 0.20);
                }
                if (evaluation == "positive")
                {
                    presidentApartment = presidentApartment + (presidentApartment * 0.25);
                    Console.WriteLine($"{(presidentApartment.ToString("0.00"))}");
                    return;
                }
                else if (evaluation == "negative")
                {
                    presidentApartment = presidentApartment - (presidentApartment * 0.10);
                    Console.WriteLine($"{(presidentApartment.ToString("0.00"))}");
                    return;
                }
            }
        }


        }
    }

