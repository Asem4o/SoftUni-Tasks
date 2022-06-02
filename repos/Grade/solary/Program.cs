using System;

namespace solary
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberTabs = int.Parse(Console.ReadLine());
            double solary = double.Parse(Console.ReadLine());

            for (int i = 0; i < numberTabs; i++)
            {
                string tab = Console.ReadLine();
                switch (tab)
                {
                    case "Facebook":
                        solary -= 150;
                        break;
                    case "Instagram":
                        solary -= 100;
                        break;
                    case "Reddit":
                        solary -= 50;
                        break;
       
                }
                if (solary <=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }


            }                      
                Console.WriteLine(solary);
        }
    }
}
