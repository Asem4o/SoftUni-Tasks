using System;

namespace passwordsGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());

            for (int first = 1; first <= n; first++)
            {
                for (int second = 1; second <= n; second++)
                {
                    for (int third = 1; third<= m; third++)
                    {
                        if (third > second && third > first)
                        {
                            Console.WriteLine($"{first}{second}{third} ");

                        }

                    }

                }

            }
           

        }
    }



}


