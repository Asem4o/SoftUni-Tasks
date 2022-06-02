using System;

namespace travelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string packet = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            bool istrue = true;
            switch (town)
            {
                case "Bansko":
                    if (packet == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (packet == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (packet == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (packet == "withBreakfast")
                    {
                        price = 130;
                    }
                    if (vip == "yes")
                    {
                        price -= price * 0.10 ;
                    }
                    break;
                case "Borovets":
                    if (packet == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (packet == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (packet == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (packet == "withBreakfast")
                    {
                        price = 130;
                    }
                    if (vip == "yes")
                    {
                        price -= price * 0.05;
                    }
                    break;
                case "Varna":
                    if (packet == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (packet == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (packet == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (packet == "withBreakfast")
                    {
                        price = 130;
                    }
                    if (vip == "yes")
                    {
                        price -= price * 0.12;
                    }
                    break;
                case "Burgas":
                    if (packet == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (packet == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (packet == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (packet == "withBreakfast")
                    {
                        price = 130;
                    }
                    if (vip == "yes")
                    {
                        price -= price * 0.07;
                    }
                    break;
                default:
                    break;
            }
            if (town != "Bansko" && town != "Borovets" && town != "Varna" && town != "Burgas" || packet != "noEquipment" && packet != "withEquipment" && packet != "noBreakfast" && packet != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
                return;
              
            }
            if (days >7)
            {
                days++;
            }
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }
            double finalprice = days * price;

                Console.WriteLine($"The price is {finalprice:f2}lv! Have a nice time!");
            
        }
    }
}
