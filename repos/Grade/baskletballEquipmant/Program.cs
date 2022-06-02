using System;

namespace baskletballEquipmant
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxForTreining = int.Parse(Console.ReadLine());

            double baskletballShuse1 = taxForTreining * 0.40;
            double baskletballShuse = taxForTreining - baskletballShuse1;
            double basketbolekip1 = baskletballShuse * 0.20;
            double basketbolekip = baskletballShuse - basketbolekip1;
            double baskletballs = basketbolekip / 4;
            double baskletballakseskuars  = baskletballs / 5;
            double wholesumforeveryting = taxForTreining +   baskletballShuse + basketbolekip + baskletballs + baskletballakseskuars;
            Console.WriteLine(wholesumforeveryting);

            
           
        }
    }
}
