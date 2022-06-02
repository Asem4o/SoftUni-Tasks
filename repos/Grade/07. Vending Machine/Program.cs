using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string commands = Console.ReadLine();
            double totalMoneyAccomulated = 0;
            while (commands !="Start")
            {
                double inputMoney = double.Parse(commands);
                if (inputMoney == 0.1 || inputMoney == 0.2 || inputMoney ==0.5 || inputMoney ==1 || inputMoney ==2)
                {
                    totalMoneyAccomulated += inputMoney;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {inputMoney}");
                }
                commands = Console.ReadLine();   
            }
            commands = Console.ReadLine();
            double totalPrice = 0;
            while (commands !="End")
            { 
                switch (commands)
                {
                    case "Nuts":
                        totalPrice = 2;
                        break;
                    case "Water":
                        totalPrice = 0.7;
                        break;
                    case "Crisps":
                        totalPrice = 1.5;
                        break;
                    case "Soda":
                        totalPrice = 0.8;
                        break;
                    case "Coke":
                        totalPrice = 1;
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        commands = Console.ReadLine();
                        continue;
                }

                if (totalMoneyAccomulated>=totalPrice)
                {
                    totalMoneyAccomulated -= totalPrice;
                    Console.WriteLine($"Purchased {commands.ToLower()}");
                }
                else
                {
                    Console.WriteLine("Sorry, not enough money");
                }
                commands = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoneyAccomulated:f2}");

        }
    }
}
