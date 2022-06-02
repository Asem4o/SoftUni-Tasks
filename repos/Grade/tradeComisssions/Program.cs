using System;

namespace tradeComisssions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double money = double.Parse(Console.ReadLine());

            if (town == "Sofia")
            {
                if (money >=0 && money <=500)
                {
                    money =money * 0.05;
                    Console.WriteLine($"{money:f2}");
                }
                else if (money >500 && money <=1000)
                {
                    money = money* 0.07;
                    Console.WriteLine($"{money:f2}");
                }
                else if (money>1000 && money <= 10000)
                {
                    money = money * 0.08;
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 10000)
                {
                    money = money * 0.12;
                    Console.WriteLine($"{money:f2}");
                }

            }
            else if (town == "Varna")
            {
                if (money >= 0 && money <= 500)
                {
                    money = Math.Abs(money * 0.045);
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    money = Math.Abs(money * 0.075);
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 1000 && money <=10000)
                {
                    money =money * 0.10;
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 10000)
                {
                    money =Math.Abs( money * 0.13);
                    Console.WriteLine($"{money:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else if (town == "Plovdiv")
            {
                if (money >= 0 && money <= 500)
                {
                    money = Math.Abs(money * 0.055);
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 500 && money <= 1000)
                {
                    money = money *0.08;
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 1000 && money <= 10000)
                {
                    money = money * 0.12;
                    Console.WriteLine($"{money:f2}");
                }
                else if (money > 10000)
                {
                    money =Math.Abs( money * 0.145);
                    Console.WriteLine($"{money:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
