using System;

namespace bonusScoreWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0;
            if (num <=100)
            {
                bonus = 5;
            }
            else if (num >100 && num <=1000)
            {
                bonus = num * 0.20;
            }
            else
            {
                bonus = num * 0.10;
            }
            if (num % 2 ==0)
            {
                bonus = bonus + 1;
            }
            else if (num % 10 == 5)
            {
                bonus = bonus + 5;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(num + bonus);
        }
    }
}
