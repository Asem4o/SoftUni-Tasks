using System;

namespace gameName1
{
    class Program
    {
        static void Main(string[] args)
        {
			string winner = "";
			int maxPoints = 0;
			string name = Console.ReadLine();

			while (name != "Stop")
			{
				int currentPoints = 0;
				foreach (char c in name)
				{
					int number = int.Parse(Console.ReadLine());
					if (number == c)
					{
						currentPoints += 10;
					}
					else
					{
						currentPoints += 2;
					}

				}
				if (currentPoints >= maxPoints)
				{
					winner = name;
					maxPoints = currentPoints;
				}
				name = Console.ReadLine();
			}

			Console.WriteLine($"The winner is {winner} with {maxPoints} points!");

		}
	}
}
