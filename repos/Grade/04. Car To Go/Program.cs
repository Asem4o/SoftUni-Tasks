    using System;

    namespace _04._Car_To_Go
    {
        class Program
        {
            static void Main(string[] args)
            {
                double budget = double.Parse(Console.ReadLine());
                string sesons = Console.ReadLine();
                double priceForCars = 0;
                string car = "";
                string clas = "";
                if (budget <= 100)
                {
                    if (sesons == "Summer")
                    {
                        priceForCars += budget * 0.35;
                        car = "Cabrio";
                    }
                    else if (sesons == "Winter")
                    {
                        priceForCars += budget * 0.65;
                        car = "Jeep";
                    }
                    clas = "Economy class";
                }
                else if (budget > 100 && budget <= 500)
                {
                    if (sesons == "Summer")
                    {
                        priceForCars += budget * 0.45;
                        car = "Cabrio";
                    }
                    else if (sesons == "Winter")
                    {
                        priceForCars += budget * 0.80;
                        car = "Jeep";
                    }
                    clas = "Compact class";
                }
                else
                {
                    priceForCars += budget * 0.90;
                    car = "Jeep";
                    clas = "Luxury class";
                }
                Console.WriteLine(clas);
                Console.WriteLine($"{car} - {priceForCars:f2}");
            }
        }
    }
