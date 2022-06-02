using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int ticketsAdults = int.Parse(Console.ReadLine());
            int ticketsKids = int.Parse(Console.ReadLine());
            double netPriceTicketAdult = double.Parse(Console.ReadLine());
            double serviceCost = double.Parse(Console.ReadLine());

            double netPriceTicketKid = netPriceTicketAdult * 0.3;

            double grossPriceTicketAdult = netPriceTicketAdult + serviceCost;
            double grossPriceTicketKid = netPriceTicketKid + serviceCost;

            double totalAmount = (grossPriceTicketAdult * ticketsAdults) 
                + (grossPriceTicketKid * ticketsKids);
            double profit = 0.2 * totalAmount;

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");
        }
    }
}
