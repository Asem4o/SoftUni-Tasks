using System;

namespace travelAgency2._0
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
            bool isTrue = false;
            switch (town)
            {
                case "Bansko":
                    if (package == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (package == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (package == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (package== "withBreakfast")
                    {
                        price = 130;
                    }
                    if (vip =="yes")
                    {
                        price -= price * 0.10;
                    }
                    break;
                case "Borovets":
                    if (package == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (package == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (package == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (package == "withBreakfast")
                    {
                        price = 130;
                    }
                   else if (vip == "yes")
                    {
                        price -= price * 0.05;
                    }
                    
                    break;
                case "Varna":
                    if (package == "noEquipment")
                    {
                        price = 80;
                    }
                    else if (package == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (package == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (package == "withBreakfast")
                    {
                        price = 130;
                    }
                   else if (vip == "yes")
                    {
                        price -= price * 0.12;
                    }
                    break;
                case "Burgas":
                    if (package == "noEquipment")
                    {
                        price  = 80;
                    }
                    else if (package == "withEquipment")
                    {
                        price = 100;
                    }
                    else if (package == "noBreakfast")
                    {
                        price = 100;
                    }
                    else if (package == "withBreakfast")
                    {
                        price = 130;
                    }
                   else if (vip == "yes")
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
            else if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }


            if (town !="Burgas" && town != "Borovets" && town != "Bansko" && town != "Varna" || package!= "noEquipment"&&package!= "withEquipment" && package != "noBreakfast" && package != "withBreakfast")
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {price * days:f2}lv! Have a nice time!");
            }
        }
    }
}
