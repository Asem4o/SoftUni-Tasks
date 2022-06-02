using System;

namespace _01._Match_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string vipOrNot = Console.ReadLine();
            int numOfPeople = int.Parse(Console.ReadLine());
            double ticket = 0;
            if (vipOrNot == "VIP")
            {
                if (numOfPeople >=1 && numOfPeople <=4)
                {
                    budget *= 0.25;
                }
                else if (numOfPeople >= 5 && numOfPeople <=9)
                {
                    budget *= 0.4;
                }
                else if (numOfPeople >=10 && numOfPeople <=24)
                {
                    budget *= 0.5;
                }
                else if (numOfPeople >=25 && numOfPeople <=49)
                {
                    budget *= 0.6;
                }
                else if (numOfPeople >=50)
                {
                    budget *= 0.75;
                }
                ticket = 499.99 * numOfPeople;
            }
            if (vipOrNot == "Normal")
            {
                if (numOfPeople >=1 && numOfPeople <=4)
                {
                    budget *= 0.25;
                }
                else if (numOfPeople >=5 && numOfPeople <=9)
                {
                    budget *= 0.4;
                }
                else if (numOfPeople >=10 && numOfPeople <=24)
                {
                    budget *= 0.5;
                }
                else if (numOfPeople >=25 && numOfPeople <=49)
                {
                    budget *= 0.6;
                }
                else if (numOfPeople >=50)
                {
                    budget *= 0.75;
                }
                ticket = 249.99 * numOfPeople;
            }
            if (ticket <=budget)
            {
               
                budget -= ticket;
                Console.WriteLine($"Yes! You have {budget:f2} leva left.");
            }
            else    
            {
                ticket -= budget;
                Console.WriteLine($"Not enough money! You need {ticket:f2} leva.");
            }

        }
    }
}
