using System;

namespace NewHouse
{
    class NewHouse
    {
        static void Main()
        {
            string flowerType = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double priceForRoses = count * 5.00;
            double priceForDahlias = count * 3.80;
            double priceForTulips = count * 2.80;
            double priceForNarcissus = count * 3.00;
            double priceForGladiolus = count * 2.50;

            double price = 0;
            if (flowerType=="Roses")
            {
                if (count >80)
                {
                    price = priceForRoses - (priceForRoses * 0.10);
                }
                else
                {
                    price = priceForRoses;
                }

            }
            else if (flowerType == "Dahlias")
            {
                if (count > 90)
                {
                    price = priceForDahlias - (priceForDahlias * 0.15);
                }
                else
                {
                    price = priceForDahlias;
                }

            }
            else if (flowerType == "Tulips")
            {
                if (count > 80)
                {
                    price = priceForTulips - (priceForTulips * 0.15);
                }
                else
                {
                    price = priceForTulips;
                }

            }
            else if (flowerType == "Narcissus")
            {
                if (count < 120)
                {
                    price = priceForNarcissus + (priceForNarcissus * 0.15);
                }
                else
                {
                    price = priceForNarcissus;
                }

            }
            else if (flowerType == "Gladiolus")
            {
                if (count < 80)
                {
                    price = priceForGladiolus + (priceForGladiolus * 0.20);
                }
                else
                {
                    price = priceForGladiolus;
                }

            }
            double moreMoney = budget - price;
            double neededMoney = price-budget;

            if (price <=budget)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {flowerType} and {moreMoney:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }

        }
           

    }
}
