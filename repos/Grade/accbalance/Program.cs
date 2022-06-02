using System;

namespace accbalance
{
    class Program
    {
        static void Main(string[] args)
        {
            double money = 0;
            string input = Console.ReadLine();
            while (input != "NoMoreMoney")
            {
                double inputAnswer = double.Parse(input);
                if (inputAnswer <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                Console.WriteLine($"Increase:{inputAnswer}");
                money += inputAnswer;
                input = Console.ReadLine();
            }
            Console.WriteLine($"Total: {money:f2}");
        }
    }
}
