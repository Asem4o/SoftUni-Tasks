using System;

namespace sumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magic = int.Parse(Console.ReadLine());
            int count = 0;
            bool flag = false;
            for (int i = start; i <= stop; i++)
            {
                for (int j = start; j <= stop; j++)
                {
                    count++;
                    if (i + j == magic)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {j} = {magic})");
                        flag = true;
                        break;
                    }
                    
                }
                if (flag)
                {
                    break;
                }
            }
            if (!flag)
            {
                Console.WriteLine($"{count} combinations - neither equals {magic}");
            }
            
        }
    }
}
