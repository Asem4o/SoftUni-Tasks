using System;

namespace foodDelivary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChikenMenu = int.Parse(Console.ReadLine());
            int numberFishMenu = int.Parse(Console.ReadLine());
            int numberVeganMenu = int.Parse(Console.ReadLine());

            double chikenMenu = 10.35;
            double fishMenu = 12.40;
            double veganMenu = 8.15;
            double delivary = 2.50;

            double pricForChikenMenu = numberChikenMenu * chikenMenu;
            double pricForFishMenu = numberFishMenu * fishMenu;
            double pricForVeganMenu = numberVeganMenu * veganMenu;

            double wholePrice = pricForChikenMenu + pricForFishMenu + pricForVeganMenu;
            double priceForSweets = wholePrice * 0.20;
            double wholePurchises = wholePrice + priceForSweets + delivary;

            Console.WriteLine(wholePurchises);

        }
    }
}
