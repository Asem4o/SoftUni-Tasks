using System;

namespace supplaiesForSchool
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberPackegesPen = int.Parse(Console.ReadLine());
            int numberPackegesMarker = int.Parse(Console.ReadLine());
            int liturPreparateForDesk = int.Parse(Console.ReadLine());
            int procentDiscount = int.Parse(Console.ReadLine());

            double packegPens = 5.80;
            double packegMarkers = 7.20;
            double preparate =1.2;

            double priceForPens = numberPackegesPen * packegPens;
            double priceForMarkers = numberPackegesMarker * packegMarkers;
            double priceForPreparate = liturPreparateForDesk * preparate;
            

            double allMaterials = priceForPens + priceForMarkers + priceForPreparate;
            double priceWithDiscoint = allMaterials - ((allMaterials*procentDiscount))/100;

            Console.WriteLine (priceWithDiscoint) ;
        }
    }
}
