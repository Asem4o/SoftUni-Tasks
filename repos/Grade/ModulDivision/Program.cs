using System;

namespace ModulDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            //loop 1 to 107=
            //if  Num % 10 = 7;


            //107 / 7  = 10;
            //10*10 = 100;
            //107 -100 = 7;
            //Num  % 10 = 7;= ще връща 7
            for (int asen = 1; asen <= 1000; asen++)
            {
                if (asen % 10 == 7)
                {
                    Console.WriteLine(asen);
                }
            }




        }

    }
}
