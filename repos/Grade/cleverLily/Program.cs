using System;

namespace cleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washing = double.Parse(Console.ReadLine());
            double toys = double.Parse(Console.ReadLine());

            double money = 0;
            int toysForBoy = 0;
            double lents = 10;
            double brotherMoney = 0;


            for (int i = 1; i <= age; i++)
            {
                if (i % 2==0)
                {
                    money += lents;
                    lents += 10;
                    brotherMoney += 1;
                }
                else
                {
                    toysForBoy += 1;
                }
            }
            double sumForToys = toysForBoy * toys;
            double allsum = (money + sumForToys) - brotherMoney;
            if (allsum>=washing)
            {
                double gege = allsum - washing;
                Console.WriteLine($"Yes! {gege:f2}");
            }
            else
            {
                double aa = washing - allsum;
                Console.WriteLine($"No! {aa:f2}");
            }
            
           
        }
    }
}
