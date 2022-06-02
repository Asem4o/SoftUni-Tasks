using System;

namespace smartLyLy
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLyly = int.Parse(Console.ReadLine());
            double priceForWashing = double.Parse(Console.ReadLine());
            double priceForToys = double.Parse(Console.ReadLine());

            double money = 0;
            double toys = 0;
            double years = 0;

            for (int i = 1; i <=ageLyly; i+=1)
            {
            
                if (i % 2==0)
                {
                    money += 10 + (toys - 1) * 10;
                    years += 1;
                }
                else
                {
                    toys += 1;
                }

            }
            double allМoney = (money - years) + (toys * priceForToys);
            if (allМoney >=priceForWashing)
            {
                double a = allМoney - priceForWashing;
                Console.WriteLine($"Yes! {a:f2}");
            }
            else
            {
                double b = priceForWashing - allМoney;
                Console.WriteLine($"No! {b:f2}");
            }

            
        }
    }
}
