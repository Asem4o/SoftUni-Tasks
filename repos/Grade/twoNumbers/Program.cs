using System;

namespace twoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            for (int num = 1; num <=10; num++)
            {
                for (int num1 = 1; num1 <=10; num1++)
                {
                    Console.WriteLine($"{num} * {num1} = {num * num1}");
                    if (num == 5 && num1 == 7)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                {
                    break;
                }
               
            }
        }
    }
}
