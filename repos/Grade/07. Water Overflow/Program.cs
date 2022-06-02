using System;

namespace _07._Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int WATER_TANK_FUEL = 255;
            int nLine = int.Parse(Console.ReadLine());
            int capacity = WATER_TANK_FUEL;
          // int currentQuantities = 0;
          // int counter = 0;
            for (int i = 0; i < nLine; i++)
            {
              int quantities = int.Parse(Console.ReadLine());
                //currentQuantities += quantities;
                if (capacity - quantities >= 0)
                {
                    capacity -= quantities;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
                
            }
            int totalFuel = WATER_TANK_FUEL - capacity;
            Console.WriteLine(totalFuel);

        }
    }
}
