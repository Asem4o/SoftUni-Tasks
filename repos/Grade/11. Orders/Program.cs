using System;

namespace _11._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double priceForCapsula = 0;
            int days = 0;
            int capsulas = 0;
            double orderPrice = 0;
            for (int i = 1; i <=num; i++)
            {
                priceForCapsula = double.Parse(Console.ReadLine());
                days = int.Parse(Console.ReadLine());
                capsulas = int.Parse(Console.ReadLine());
                orderPrice = (days * capsulas) * priceForCapsula;
                Console.WriteLine(orderPrice);
                if (num != num + 1)
                {
                    Console.WriteLine(orderPrice);

                }
            }

            Console.WriteLine(orderPrice);
        }
    }
}
