using System;

namespace repaiting
{
    class Program
    {
        static void Main(string[] args)
        {
            int naylonInMeeters = int.Parse(Console.ReadLine());
            int paitingInLiurs = int.Parse(Console.ReadLine());
            int razreditelInLiturs = int.Parse(Console.ReadLine());
            int hoursForMaistors = int.Parse(Console.ReadLine());


            double defendingNaylon = 1.50;
            double paint = 14.50;
            double razreditel = 5.00;
            double torbichki = 0.40;

            double priceForNaylon = (naylonInMeeters + 2) * defendingNaylon;
            double discountForPaint = (paitingInLiurs * 0.10);
            double priceForPaint = (paitingInLiurs * discountForPaint) * paint;
            double priceForRazeditel = razreditelInLiturs * razreditel;
            double wholeSum = priceForNaylon + priceForPaint + priceForRazeditel + torbichki;
            double sumForMaistor = (wholeSum * 0.30) * hoursForMaistors;
            double finalSum = wholeSum + sumForMaistor;


            Console.WriteLine(finalSum);

        }
    }
}
