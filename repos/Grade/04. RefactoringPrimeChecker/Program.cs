using System;

namespace _04._RefactoringPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLine = int.Parse(Console.ReadLine());
            int nLineCounter = 1;
            for (int takoa = 2; takoa <= nLine; takoa++)
            {
                nLineCounter++;
                string result = "true";
                for (int cepitel = 2; cepitel < takoa; cepitel++)
                {
                    if (takoa % cepitel == 0)
                    {
                        result = "false";
                        break;
                    }
                }
                Console.WriteLine($"{nLineCounter} -> {result}");
            }

        }
    }
}
