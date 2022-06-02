using System;

namespace _04._Trekking_Mania
{
    class Program
    {
        static void Main(string[] args)
        {
            int numGrups = int.Parse(Console.ReadLine());
            int numPeople = 0;
            int totalPeople = 0;
            double Musala = 0;
            double Monblan = 0;
            double Kilimandjaro = 0;
            double K2 = 0;
            double Everest = 0;
            for (int i = 1; i <= numGrups; i++)
            {
                numPeople =int.Parse(Console.ReadLine());
                totalPeople += numPeople;
                if (numPeople <=5)
                {
                    Musala += numPeople;
                }
                else if (numPeople >=6 && numPeople <=12)
                {
                    Monblan +=numPeople ;               
                }
                else if (numPeople >=13 && numPeople <=25)
                {
                    Kilimandjaro += numPeople ; 
                }
                else if (numPeople >=26 && numPeople <=40)
                {
                    K2 += numPeople ;   
                }
                else if (numPeople >=41)
                {
                    Everest += numPeople;
                }
               
            }
            Console.WriteLine($"{(Musala / totalPeople)*100:f2}%");
            Console.WriteLine($"{(Monblan / totalPeople)*100:f2}%");
            Console.WriteLine($"{(Kilimandjaro / totalPeople)*100:f2}%");
            Console.WriteLine($"{(K2 / totalPeople)*100:f2}%");
            Console.WriteLine($"{(Everest / totalPeople)*100:f2}%");
        }
    }
}
