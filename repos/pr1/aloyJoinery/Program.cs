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
            double discount = 0;

            if (countJoinery <10)
            {
                Console.WriteLine("Invalid order");
                return;

            }
            else if (typeJoinery=="90X130")
            {
                price = 110 * countJoinery;

                if (countJoinery>=30 && countJoinery <60)
                {
                    discount = price * 0.05;
                    price -= discount;
                }
               else  if (countJoinery>=60)
                {
                    discount = price * 0.08;
                    price -= discount;
                } 
            }
            else if (typeJoinery == "100X150")
            {
                price = 140 * countJoinery;
                if (countJoinery >= 40 && countJoinery < 80)
                {
                    discount = price * 0.06;
                    price -= discount;
                }
               else if (countJoinery >= 80)
                {
                    discount = price * 0.10;
                    price -= discount;
                }
            }
            else if (typeJoinery == "130X180")
            {
                price = 190 * countJoinery;
                if (countJoinery >= 20 && countJoinery < 50)
                {
                    discount = price * 0.07;
                    price -= discount;
                }
               else if (countJoinery >= 50)
                {
                    discount = price * 0.12;
                    price -= discount;
                }
            }
            else if (typeJoinery == "200X300")
            {
                price = 250 * countJoinery;
                if (countJoinery >= 25 && countJoinery < 50)
                {
                    discount = price * 0.09;
                    price -= discount;
                }
                else if (countJoinery >= 50)
                {
                    discount = price * 0.14;
                    price -= discount;
                }
            }
            if (typeDelivary == "With delivery")
            {
                price += 60;
            }
            if (countJoinery >99)
            {
                price -= price * 0.04;
            }

            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
