using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            string partPrice = Console.ReadLine();
            double currentInput = 0;
            double price = 0;
            double finalPrice = 0;
            double tax = 0;
            double discont = 0;
            while (true)
            {
               
                if (partPrice == "special")
                {
                    discont = (price + tax )* 0.1;
                    break;
                }
                else if (partPrice == "regular")
                {
                    break;
                }
                currentInput = double.Parse(partPrice);
                partPrice = Console.ReadLine();
                if (currentInput < 0)
                {
                    Console.WriteLine("Invalid price!");
                    continue;
                }
                price += currentInput;
                tax = price * 0.2;

            }         
            finalPrice = price + tax - discont;
            if (finalPrice == 0)
            {
                
                Console.WriteLine("Invalid order!");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {price:f2}$");
                Console.WriteLine($"Taxes: {tax:f2}$");
                Console.WriteLine($"-----------");
                Console.WriteLine($"Total price: {finalPrice:f2}$");
            }

        }
    }
}
