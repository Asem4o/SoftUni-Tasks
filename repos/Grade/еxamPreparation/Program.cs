using System;

namespace еxamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            int poorGradeLimits = int.Parse(Console.ReadLine());
            double sum = 0;
            int problemCount = 0;
            string problemName = "";
            int poorGradesCount = 0;
            bool needsBreak = false;
            while (!needsBreak )
            {
                string input = Console.ReadLine();
                if (input =="Enough")
                {
                    break;
                }
                problemName = input;
                problemCount++;
                int grade = int.Parse(Console.ReadLine());
                if (grade <=4)
                {
                    poorGradesCount++;
                }

                if (poorGradesCount == poorGradeLimits)
                {
                    needsBreak = true;
                }
                sum += grade;
            }
            if (needsBreak )
            {
                Console.WriteLine($"You need a break, {poorGradesCount} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {sum / problemCount:f2}");
                Console.WriteLine($"Number of problems: {problemCount}");
                Console.WriteLine($"Last problem: {problemName}");

            }
          
        }
    }
}
