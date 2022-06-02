using System;

namespace logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int kg = 0;  
            double microbus = 200;
            double truck = 175;
            double train = 120;
            double allkg = 0;
            double final = 0;
            double microbusInProcents = 0;
            double truckInProcents = 0;
            double trainkInProcents = 0;
            int kilom = 0;
            int kilotruck = 0;
            int kilotrain = 0;
            for (int i = 0; i <count ; i++)
            {
                kg = int.Parse(Console.ReadLine());
                allkg += kg;
                if (kg >1&&kg <=3)
                {
                    kg ++;
                    microbus *= kg;
                     kilom = kg;
                }
                if (kg >4 && kg<=11)
                {
                    truck *= kg;

                    kilotruck = kg;
                }
                if (kg >12)
                {
                    train *= kg;
                     kilotrain = kg;
                }
                final = (microbus + truck + train) / allkg;
               
            }
            microbusInProcents = (kilom / allkg) * 100;
            truckInProcents = (kilotruck / allkg) * 100;
            trainkInProcents = (kilotrain / allkg) * 100;
            Console.WriteLine(final);
            Console.WriteLine(microbusInProcents);
            Console.WriteLine(truckInProcents);
            Console.WriteLine(trainkInProcents);

        }
    }
}
