using System;

namespace oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double score = double.Parse(Console.ReadLine());
            int numberPeople = int.Parse(Console.ReadLine());
            

            string nameOfActurs = "";
            double moreScore = 0;
            int namewhat = 0;
            double check = 0;
            for (int i = 0; i < numberPeople; i++)
            {
                nameOfActurs = Console.ReadLine();
                moreScore = double.Parse(Console.ReadLine());
                namewhat = nameOfActurs.Length;
                check = (namewhat * moreScore) / 2;
                score += check;
                if (score >1250.5)
                {
                    break;
                }

            }
            if (score > 1250.5)
            {
                Console.WriteLine($"Congratulations, {name} got a nominee for leading role with {score:f1}!");
            }
            else
            {
                Console.WriteLine($"Sorry, {name} you need {1250.50-score:f1} more!");
            }
            
        }
    }
}
