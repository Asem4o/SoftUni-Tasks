using System;

namespace sMEEENI
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int max1 = int.Parse(Console.ReadLine());
            int max2= int.Parse(Console.ReadLine());
            int max3 = int.Parse(Console.ReadLine());
            int max4 = int.Parse(Console.ReadLine());

           
            for (int d1 = max1; d1 <=8; d1++)
            {              
                for (int d2 = 9; d2 >=max2; d2--)
                {
                    for (int d3 = max3; d3 <= 8; d3++)
                    {
                        for (int d4 = 9; d4 >= max4; d4--)
                        {
                            if (d1 %2 == 0 && d2 % 2 !=0 && d3 %2 ==0 && d4 % 2!=0 )
                            {
                                if (d1 == d3 && d2 == d4)
                                {
                                    Console.WriteLine("Cannot change the same player.");
                                }
                                else
                                {
                                    Console.WriteLine($"{d1}{d2} - {d3}{d4}");
                                }
                               
                            }
                           
                        }

                    }
                }
                
            }
         

        }
    }
}
