using System;

namespace operationBetweenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            string operators = Console.ReadLine();
            double answer = 0;
            string evenOrOdd = "";
            switch (operators)//!!!!
            {
                case "/":
                case "%":
                    if (n2 == 0)
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                        return;//
                    }
                    break;
                default:
                    break;
            }
            switch (operators)//!!
            {
                case "+":
                    answer = n1 + n2;
                    break;
                case "-":
                    answer = n1 - n2;
                    break;
                case "*":
                    answer = n1 * n2;
                    break;
                case "/":
                   
                    answer = n1*1.0 / n2;
                    Console.WriteLine($"{n1} / {n2} = {answer:f2}");
                    return;// спира изпълнението на програмата !!!
                case "%":
                    answer = n1 % n2;
                    break;
                default:
                    break;
            }
            switch (operators)//!
            {
                case "+":
                case "-":
                case "*":
                    if (answer % 2 == 0)
                    {
                        evenOrOdd = " - even";
                    }
                    else
                    {
                        evenOrOdd = " - odd";
                    }
                    break;
                default:
                    break;

            }
            Console.WriteLine($"{n1} {operators} {n2} = {answer}{evenOrOdd}");



        }
    }
}
