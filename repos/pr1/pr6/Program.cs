using System;

namespace pr6
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            int start1 = start / 1000;
            int start2 = (start / 100) % 10;
            int start3 = (start / 10) % 10;
            int start4 = start % 10;
            int end1 = end / 1000;
            int end2 = (end / 100) % 10;
            int end3 = (end / 10) % 10;
            int end4 = end % 10;

            for (int i = start1; i <= end1; i++)
            {
                for (int j = start2; j <= end2; j++)
                {
                    for (int  k = start3; k <= end3; k++)
                    {
                        for (int l = start4; l <= end4; l++)
                        {
                            if (i %2 !=0 && j%2!=0 && k%2!=0 && l%2!=0)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                
                            }
                        }
                    }
                }
            }

        }
    }
}
