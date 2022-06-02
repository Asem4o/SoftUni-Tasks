using System;

namespace _08._Triangle_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int endNum = int.Parse(Console.ReadLine());
            int num = 0;
            for (int raw = 1; raw <=endNum; raw++)
            {
                num++;
                for (int colom = 1; colom <=raw; colom++)
                {
                    Console.Write($"{num} ");
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
