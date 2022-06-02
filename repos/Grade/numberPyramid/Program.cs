using System;

namespace numberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum =Math.Abs(int.Parse(Console.ReadLine()));
            int num = 1;
            for (int raw = 1; raw <=endNum; raw++)
            {
                for (int colum = 1; colum <=raw; colum++)
                {
                    Console.Write($"{num++} ");
                    if (num > endNum)
                    {
                        break;
                    }
                }
                if (num > endNum)
                {
                    break;
                }
                Console.WriteLine();
            }
           
        }
    }
}
