using System;

namespace aloyJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int countJoinery = int.Parse(Console.ReadLine());
            string typeJoinery = Console.ReadLine();
            string typeDelivary = Console.ReadLine();
            double price = 0;

            if (countJoinery <10)
            {
                Console.WriteLine("invalid");
            }
            else if (countJoinery >=10 && kindJoinery=="90X130")
            {
               
              
               
                if (countJoinery>=30)
                {
                    price = (price * 0.05) ;
                   

                }
                else if (countJoinery>=60)
                {
                    price = (price * 0.08) - price;
                  
                }
                double gg = price*countJoinery
                Console.WriteLine(gg);
            }
        }
    }
}
