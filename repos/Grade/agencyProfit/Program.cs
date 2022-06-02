using System;

namespace agencyProfit
{
    class Program
    {
        static void Main(string[] args)
        {
            string airLane = Console.ReadLine();
            int ticketForAdults = int.Parse(Console.ReadLine());
            int ticketForKids = int.Parse(Console.ReadLine());
            double priceForTicketForAdults = double.Parse(Console.ReadLine());
            double priceForServices = double.Parse(Console.ReadLine());
            double discountForKids = priceForTicketForAdults * 0.70;
            double priceForKids = priceForTicketForAdults - discountForKids;
            double finalPriceForAdults = priceForTicketForAdults + priceForServices;
            double finalPriceForKids = priceForKids + priceForServices;
            double totalPrice = (ticketForKids * finalPriceForKids) + (ticketForAdults * finalPriceForAdults);
            double profit = totalPrice * 0.20;
            Console.WriteLine($"The profit of your agency from {airLane} tickets is {profit:f2} lv.");
        }
    }
}
