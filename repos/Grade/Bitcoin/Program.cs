using System;

namespace Bitcoin
{
    class Program
    {
        static void Main(string[] args)
        {

            int bitcoin = int.Parse(Console.ReadLine());
            double uan = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());
            double bitkoin = 1168;
            double uana = 0.15;
            double usd = 1.76;
            double euro = 1.95;
            double priceforBitcoin = bitcoin * bitkoin;
            double priceForUan = (uan * uana) * usd;
            double totalPrice = (priceforBitcoin + priceForUan) / euro;
            double priceWithDiscount = (totalPrice *commision)/100;
            double result = totalPrice - priceWithDiscount;
            Console.WriteLine($"{result:f2}");


        }
    }
}
