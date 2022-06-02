using System;

namespace _01._Back_To_The_Past
{
    class Program
    {
        static void Main(string[] args)
        {
            double legacyMoney = double.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            double money = 12000;
            double spendMoney =0;
            int newYear = 1800;
            int ivan = 17;
            for (int i = 1800; i <=year; i++)
            {
                ivan++;
               
                if (newYear % 2==0)
                {
                    legacyMoney -= 12000;
                }
                 if (newYear % 2 !=0)
                {
                   spendMoney=(ivan *50)+12000;
                    legacyMoney -= spendMoney;

                }
                newYear++;
            }
            if (legacyMoney >= spendMoney)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {legacyMoney:f2} dollars left.");
            }
            else
            {
               Console.WriteLine($"He will need {Math.Abs(legacyMoney):f2} dollars to survive.");
           }
        }
    }
}
