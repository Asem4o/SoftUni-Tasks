using System;

namespace trackingMania
{
    class Program
    {
        static void Main(string[] args)

        {
            int people = int.Parse(Console.ReadLine());
            int group = 0;
            int musala = 0;
            int monblan = 0;
            int kilimandjaro = 0;
            int k2 = 0;
            int everst = 0;
            int allMountains = 0;

            for (int i = 0; i <people; i++)
            {
                group = int.Parse(Console.ReadLine());
                if (group <=5)
                {
                    musala += group;
                }
                else if (group >=6 && group <=12)
                {
                    monblan += group;
                }
                else if (group >=13 && group<=25)
                {
                    kilimandjaro += group;
                }
                else if (group >=26 && group <=40)
                {
                    k2 += group;
                }
                else if (group >=41)
                {
                    everst += group;
                }
            }
            allMountains = musala + monblan + kilimandjaro + k2 + everst;
            Console.WriteLine($"{1.0*musala/allMountains*100:f2}%");
            Console.WriteLine($"{1.0*monblan/allMountains*100:f2}%");
            Console.WriteLine($"{1.0*kilimandjaro/allMountains*100:f2}%");
            Console.WriteLine($"{1.0*k2/allMountains*100:f2}%");
            Console.WriteLine($"{1.0*everst/allMountains*100:f2}%");
        }
    }
}
