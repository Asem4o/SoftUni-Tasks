using System;

namespace pcFirm
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPc = int.Parse(Console.ReadLine());
            int currentRating = 0;
            double possibleSals = 0;
            double rating = 0;
            double avgRating = 0;
            double finalSum = 0;
            double allRaring = 0;
            for (int i = 0; i < numPc; i++)
            {
               
                currentRating = int.Parse(Console.ReadLine());
                rating = currentRating % 10;
                possibleSals = currentRating / 10;
                avgRating += rating;
                if (rating == 3)
                {
                    possibleSals = possibleSals * 0.5;
                    allRaring += possibleSals;
                }
                else if (rating == 4)
                {
                    possibleSals = possibleSals * 0.7;
                    allRaring += possibleSals;
                }
                else if (rating == 5)
                {
                    possibleSals = possibleSals * 0.85;
                    allRaring += possibleSals;
                }
               else  if (rating == 6)
                {
                    possibleSals = possibleSals * 1;
                    allRaring += possibleSals;
                }
                finalSum = avgRating / numPc;

                Console.WriteLine($"{finalSum:f2}");
                Console.WriteLine($"{allRaring:f2}");



            }
        }
    }
}
