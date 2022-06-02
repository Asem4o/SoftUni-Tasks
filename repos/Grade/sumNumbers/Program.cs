using System;

class SumNumbers
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        int totalSum = 0;

        for (int i = 0; i < number; i++)
        {
            int numberone = int.Parse(Console.ReadLine());
            totalSum += numberone;
        }

        Console.WriteLine(totalSum);
    }
}