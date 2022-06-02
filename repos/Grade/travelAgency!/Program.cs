using System;

namespace travelAgency_
{
    class Program
    {
        static void Main(string[] args)
        {
            //   1.Име на града -текст с възможности("Bansko",  "Borovets", "Varna" или "Burgas")
            //2.Вид на пакета -текст с възможности("noEquipment",  "withEquipment", "noBreakfast" или "withBreakfast")
            //3.Притежание на VIP отстъпка - текст с възможности  "yes" или "no"
            //4.Дни за престой -цяло число в интервала[1 … 10000]

            int noEquipment = 80;
            int withEquipment = 100;
            int noBreakfast = 100;
            int withBreakfast = 130;
            
            string town = Console.ReadLine();
            string pack = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double priceForDay = 0;
            double discount = 0;
           
            if (town == "Bansko")
            {
                if (pack == "noEquipment")
                {
                    priceForDay =  noEquipment;
                }
                else if (pack == "withEquipment")
                {
                    priceForDay =  withEquipment;
                }
                else if (pack == "noBreakfast")
                {
                    priceForDay =  noBreakfast;
                }
                else if (pack == "withBreakfast")
                {
                    priceForDay =  withBreakfast;
                }
                if (vip == "yes")
                {
                    discount = priceForDay * 0.10;
                    priceForDay = priceForDay - discount;
                  
                }
                
              
            }
            else if (town == "Borovets")
            {
                if (pack == "noEquipment")
                {
                    priceForDay = noEquipment;
                }
                else if (pack == "withEquipment")
                {
                    priceForDay =  withEquipment;
                }
                else if (pack == "noBreakfast")
                {
                    priceForDay =  noBreakfast;
                }
                else if (pack == "withBreakfast")
                {
                    priceForDay =  withBreakfast;
                }
                if (vip == "yes")
                {
                    discount = priceForDay * 0.05;
                    priceForDay = priceForDay - discount;
                }
            }
            else if (town == "Varna")
            {
                if (pack == "noEquipment")
                {
                    priceForDay = noEquipment;
                }
                else if (pack == "withEquipment")
                {
                    priceForDay =  withEquipment;
                }
                else if (pack == "noBreakfast")
                {
                    priceForDay = noBreakfast;
                }
                else if (pack == "withBreakfast")
                {
                    priceForDay = withBreakfast;
                }
                if (vip == "yes")
                {
                    discount = priceForDay * 0.12;
                    priceForDay = priceForDay - discount;
                }
            }
            else if (town == "Burgas")
            {
                if (pack == "noEquipment")
                {
                    priceForDay =  noEquipment;
                }
                else if (pack == "withEquipment")
                {
                    priceForDay =  withEquipment;
                }
                else if (pack == "noBreakfast")
                {
                    priceForDay =  noBreakfast;
                }
                else if (pack == "withBreakfast")
                {
                    priceForDay =  withBreakfast;
                }
                if (vip == "yes")
                {
                    discount = priceForDay * 0.07;
                    priceForDay = priceForDay - discount;
                }
            }
            double price = priceForDay * days;
            if (days >7)
            {
                price = price - priceForDay;
            }
            else if (days<1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if (town !="Bansko" && town != "Borovets" && town != "Varna"  && town != "Burgas" || pack != "noEquipment" && pack != "withEquipment" && pack != "noBreakfast" && pack != "withBreakfast" || vip !="yes" && vip !="no")
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {price:f2}lv! Have a nice time!");
            }
           
            
        }
    }
}
