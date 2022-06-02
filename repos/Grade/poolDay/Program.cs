using System;

namespace poolDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPeople = int.Parse(Console.ReadLine());
            double taxEnterenc = double.Parse(Console.ReadLine());
            double priceForOneShezlong = double.Parse(Console.ReadLine());
            double priceForUmbrella = double.Parse(Console.ReadLine());

            double enter = numberPeople * taxEnterenc;
            double procentigeForShezlong =Math.Ceiling( numberPeople * 0.75);
            double priceForAllShezlongs = priceForOneShezlong * procentigeForShezlong;
            double procentigeForUmbrella =Math.Ceiling(numberPeople*0.50 );
            double priceForAllUmbrellas = procentigeForUmbrella * priceForUmbrella;
            double finalPrice = enter + priceForAllShezlongs + priceForAllUmbrellas;
            Console.WriteLine($"{finalPrice:f2} lv.");



        }
    }
}
