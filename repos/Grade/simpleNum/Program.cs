using System;

namespace simpleNum
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            double card = 0;
            double money = 0;
           
            while (input !="End")
            {


                input = Console.ReadLine();
                card = int.Parse(input);
                if (card <10)
                {
                    Console.WriteLine("Error in transaction!");
                    card = 0;
                  
                }
                if (card >=10 && card <100)
                {
                    Console.WriteLine("Product sold!");
                    money += card;
                }
               
                if (card >= 100)
                {
                    Console.WriteLine("Error in transaction!");
                    card = 0;

                }

              
            }
           
        }
    }
}
