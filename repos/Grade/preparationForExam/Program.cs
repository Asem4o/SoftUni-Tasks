using System;

namespace preparationForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());
            string name = "";
            int failedTimes = 0;
            int solvedProblemCount= 0;
            int gradesSum= 0;
            bool isFailed = true;
            while (failedTimes < grade)
            {
                string problem = Console.ReadLine();
                if (problem == "Enough")
                {
                    isFailed = false;
                    break;
                }
                int grade1 = int.Parse(Console.ReadLine());
                if (grade1<=4)
                {
                    failedTimes++;
                }
                gradesSum += grade1;
                solvedProblemCount++;
                name = problem;
            }
            if (isFailed)
            {
                Console.WriteLine($"You need a break, {grade} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradesSum /solvedProblemCount:f2}");
                Console.WriteLine($"Number of problems: {solvedProblemCount}");
                Console.WriteLine($"Last problem: {name}");
            }
        }
    }
}
