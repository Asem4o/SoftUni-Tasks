using System;

namespace _5
{

class HelloWorld
		{
			static void Main()
			{
				int seaCount = int.Parse(Console.ReadLine());
				int mountainCount = int.Parse(Console.ReadLine());
				int totalPrice = 0;
				int mountainPrice = 499;
				int seaPrice = 680;
				string current = "";
				while (current != "Stop")
				{
					current = Console.ReadLine();
					if (current == "sea")
					{
						if (seaCount == 0)
						{
							continue;
						}

						seaCount--;
						totalPrice += seaPrice;
					}
					else if (current == "mountain")
					{
						if (mountainCount == 0)
						{
							continue;
						}

						mountainCount--;
						totalPrice += mountainPrice;
					}
                if (seaCount == 0 && mountainCount == 0)
                {
					break;
                }
				}

				if (seaCount == 0 && mountainCount == 0)
				{
					Console.WriteLine($"Good job! Everything is sold.\nProfit: { totalPrice} leva.");
				}
				else
				{
					Console.WriteLine($"Profit: {totalPrice} leva.");
				}
			}
		}
	}

