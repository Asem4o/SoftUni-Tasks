using System;

namespace equalSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            for (int currentNum = start; currentNum <= end; currentNum++)
            {
                int oddSum = 0;
                int evenSum = 0;
                string numAsText = currentNum.ToString();
                for (int index = 0; index < numAsText.Length; index++)
                {
                    int number = int.Parse(numAsText[index].ToString());
                    if (index % 2 == 0)
                    {
                        evenSum += number;
                    }
                    else
                    {
                        oddSum += number;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write($"{currentNum} ");
                }
            }
        }
    }
}
