using System;

namespace trainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double marksSum = 0;
            double presentationCount = 0;
            while (input !="Finish")
            {
                presentationCount++;
                double markSum = 0;
                for (int i = 1; i <= juryCount; i++)
                {
                    double mark = double.Parse(Console.ReadLine());
                    markSum += mark;
                }
                double averageMark = markSum / juryCount;
                marksSum += averageMark;
                Console.WriteLine($"{input} - {averageMark:F2}.");
                input = Console.ReadLine();
            }
            double finalMark = marksSum / presentationCount;
            Console.WriteLine($"Student's final assessment is {finalMark:F2}.");
        }
    }
}
