using System;

namespace cinemaTicket
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeeks = Console.ReadLine();
            int priceOfTicket = 0;
            if (dayOfWeeks == "Monday")
            {
                priceOfTicket = 12;
                Console.WriteLine(priceOfTicket);
            }
            else if (dayOfWeeks == "Wednesday")
            {
                priceOfTicket = 14;
                Console.WriteLine(priceOfTicket);
            }
            else if (dayOfWeeks == "Thursday")
            {
                priceOfTicket = 14;
                Console.WriteLine(priceOfTicket);
            }
        
            else if (dayOfWeeks == "Friday")
            {
                priceOfTicket = 12;
                Console.WriteLine(priceOfTicket);
            }
        
            else if (dayOfWeeks == "Saturday")
            {
                priceOfTicket = 16;
                Console.WriteLine(priceOfTicket);
            }
            else if (dayOfWeeks == "Sunday")
            {
                priceOfTicket = 16;
                Console.WriteLine(priceOfTicket);
            }
           
        }
    }
}
