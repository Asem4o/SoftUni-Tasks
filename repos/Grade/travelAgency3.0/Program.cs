using System;

namespace travelAgency3._0
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double price = 0;
            switch (town)
            {
                case "Bansko":
                    switch (package)
                    {
                        case "noEquipment":
                            price = 80;
                            break;
                        case "withEquipment":
                            price = 100;
                            break;
                        case "noBreakfast":
                            price = 100;
                            break;
                        case "withBreakfast":
                            price = 130;
                            break;
                        default:
                            break;
                    }
                    if (vip =="yes")
                    {
                        price -= price * 0.10;
                    }
                    break;
                case "Borovets":
                    switch (package)
                    {
                        case "noEquipment":
                            price = 80;
                            break;
                        case "withEquipment":
                            price = 100;
                            break;
                        case "noBreakfast":
                            price = 100;
                            break;
                        case "withBreakfast":
                            price = 130;
                            break;
                        default:
                            break;
                    }
                    if (vip == "yes")
                    {
                        price -= price * 0.05;
                    }
                    break;
                case "Varna":
                    switch (package)
                    {
                        case "noEquipment":
                            price = 80;
                            break;
                        case "withEquipment":
                            price = 100;
                            break;
                        case "noBreakfast":
                            price = 100;
                            break;
                        case "withBreakfast":
                            price = 130;
                            break;
                        default:
                            break;
                    }
                    if (vip =="yes")
                    {
                        price -= price * 0.12;
                    }
                    break;
                case "Burgas":
                    switch (package)
                    {
                        case "noEquipment":
                            price = 80;
                            break;
                        case "withEquipment":
                            price = 100;
                            break;
                        case "noBreakfast":
                            price = 100;
                            break;
                        case "withBreakfast":
                            price = 130;
                            break;
                        default:
                            break;
                    }
                    if (vip =="yes")
                    {
                        price -= price * 0.07;
                    }
                    break; 
                default:
                    break;
            }
            if (days > 7)
            {
                days++;
            }
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                
            }
            if (town != "Bansko" && town != "Borovets" && town != "Varna" && town != "Burgas" || package != "noEquipment" && package != "withEquipment" && package != "noBreakfast" && package != "withBreakfast" || vip !="yes" && vip!="no" )
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {days * price:f2}lv! Have a nice time!");
            }

        }
    }
}
