using System;

namespace _02._Bike_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            //Група   trail   cross - country   downhill      road
            //juniors 5.50    8                  12.25         20
            //seniors 7       9.50               13.75        21.50


            int juniorBikers = int.Parse(Console.ReadLine());
            int seniorrBikers = int.Parse(Console.ReadLine());
            string typeRoad = Console.ReadLine();
            double junior = 0;
            double seniors = 0;
            double price = 0;
            if (typeRoad == "trail")
            {
                junior = 5.50;
                seniors = 7.00;
                price = (juniorBikers * junior) + (seniorrBikers * seniors);
                price *= 0.95;
            }
            else if (typeRoad == "cross-country")
            {
                junior = 8.00;
                seniors = 9.50;
                price = (juniorBikers * junior) + (seniorrBikers * seniors);
                price *= 0.95;
                int compiters = juniorBikers + seniorrBikers;
                if (compiters >= 50)
                {
                    price *= 0.75;
                }
            }
            else if (typeRoad == "downhill")
            {
                junior = 12.25;
                seniors = 13.75;
                price = (juniorBikers * junior) + (seniorrBikers * seniors);
                price *= 0.95;
            }
            else if (typeRoad == "road")
            {
                junior = 20.00;
                seniors = 21.50;
                price = (juniorBikers * junior) + (seniorrBikers * seniors);
                price *= 0.95;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}
