using System;

namespace computerFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double number = 0;
            double  rating = 0;
            double possibleSels = 0;
            double discount = 0;
            double currentSels = 0;
            double totalsels = 0;

            for (int i = 0; i < n; i++)
            {
                number = int.Parse(Console.ReadLine());
                rating = number % 10;
                possibleSels = number / 10;
                
                if (rating ==3)
                {
                    discount = 0.5;
                    currentSels = possibleSels * discount;

                }
                if (rating ==4)
                {
                    discount = 0.7;
                    currentSels = possibleSels * discount;
                }
                if (rating == 5 )
                {
                    discount = 0.85;
                    currentSels = possibleSels * discount;
                }
                if (rating ==6)
                {
                    currentSels = possibleSels;
                }

                totalsels += currentSels;
            }

          
            Console.WriteLine(allsels);
        }
    }
}
