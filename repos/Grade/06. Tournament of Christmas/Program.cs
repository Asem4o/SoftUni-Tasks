using System;

namespace _06._Tournament_of_Christmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeGame = "";
            string winOrLose = "";
            double money = 0;
            int winning = 0;
            int loosing = 0;
            double dailyMoney = 0;
            int dailyWining = 0;
            int dailyLoosing = 0;
            bool flag = true;
            for (int i = 1; i <=days; i++)
            {
                while (flag)
                {
                    typeGame = Console.ReadLine();
                    if (typeGame =="Finish")
                    {
                        break;
                    }
                    winOrLose = Console.ReadLine();
                    if (winOrLose =="win")
                    {

                        dailyMoney += 20;
                        dailyWining++;
                        winning++;
                    }
                    else if (winOrLose == "lose")
                    {
                        dailyLoosing++;
                        loosing++;
                    }
                }
                if (dailyWining > dailyLoosing)
                {
                    dailyMoney += dailyMoney * 0.1;
                }
                money += dailyMoney;
                dailyMoney = 0;
                dailyWining = 0;
                dailyLoosing = 0;
               

            }
            if (loosing == winning)
            {
                return;
            }
            else if (winning >loosing)
            {
               
                Console.WriteLine($"You won the tournament! Total raised money: {money += money * 0.2:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {money:f2}");
            }
          
           
        }
    }
}
