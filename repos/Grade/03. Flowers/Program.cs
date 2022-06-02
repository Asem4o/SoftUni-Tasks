using System;

namespace _03._Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            //В празнични дни цените на всички цветя се увеличават с 15 %.Предлагат се следните отстъпки:
            //•	За закупени повече от 7 лалета през пролетта – 5 % от цената на целият букет.
            //•	За закупени 10 или повече рози през зимата – 10 % от цената на целият букет.
            //•	За закупени повече от 20 цветя общо през всички сезони – 20 % от цената на целият букет.

            //•	На първия ред е броят на закупените хризантеми – цяло число в интервала[0... 200]
            //•	На втория ред е броят на закупените рози – цяло число в интервала[0... 200]
            //•	На третия ред е броят на закупените лалета – цяло число в интервала[0... 200]
            //•	На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            //•	На петия ред е посочено дали денят е празник – [Y – да / N - не]
            // Сезон           Хризантеми      Рози     Лалета
            // Пролет / Лято   2.00 лв./ бр.    4.10 лв./ бр.    2.50 лв./ бр.
            // Есен / Зима    3.75 лв./ бр.    4.50 лв./ бр.    4.15 лв./ бр.

            int hrisantemas = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();
            string restDay = Console.ReadLine();
            double oneHrisantema = 0;
            double oneRoses = 0;
            double oneTilips = 0;
            double price = 0;
            int allFlowers = 0;
            if (seasons == "Spring" || seasons == "Summer")
            {
                oneHrisantema = 2.00;
                oneRoses = 4.10;
                oneTilips = 2.50;
                price = (hrisantemas * oneHrisantema) + (roses * oneRoses) + (tulips * oneTilips);
                allFlowers = hrisantemas + roses + tulips;
                if (tulips >= 7)
                {
                    price *= 0.95;
                }
                if (allFlowers > 20)
                {
                    price *= 0.8;
                }
            }
            if (seasons == "Autumn")
            {
                oneHrisantema = 3.75;
                oneRoses = 4.50;
                oneTilips = 4.15;
                price = (hrisantemas * oneHrisantema) + (roses * oneRoses) + (tulips * oneTilips);
                allFlowers = hrisantemas + roses + tulips;

                if (allFlowers > 20)
                {
                    price *= 0.8;
                }
            }
            else if (seasons == "Winter")
            {
                oneHrisantema = 3.75;
                oneRoses = 4.50;
                oneTilips = 4.15;
                price = (hrisantemas * oneHrisantema) + (roses * oneRoses) + (tulips * oneTilips);
                allFlowers = hrisantemas + roses + tulips;
                if (roses >= 10)
                {
                    price *= 0.90;
                }
                if (allFlowers >= 20)
                {
                    price *= 0.8;
                }
            }
            if (restDay == "Y")
            {
                price += price * 0.15;
                Console.WriteLine($"{price + 2.0:f2}");
            }
            else if (restDay == "N")
            {
                Console.WriteLine($"{price + 2.0:f2}");
            }
        }
    }
}
