using System;

namespace operationBetweenNumbersWithIfElse
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

            if (operators == "+")
            {
                answer = n1 + n2;
                if (answer%2==0)
                {
                    evenOrOdd = " - even";
                }
                else
                {
                    evenOrOdd = " - odd";
                }
                Console.WriteLine($"{n1} {operators} {n2} = {answer}{evenOrOdd}");
            }
            else if (operators == "-")
            {
                answer = n1 - n2;
                if (answer % 2 == 0)
                {
                    evenOrOdd = " - even";
                }
                else
                {
                    evenOrOdd = " - odd";
                }
                Console.WriteLine($"{n1} {operators} {n2} = {answer}{evenOrOdd}");
            }
            else if (operators == "*")
            {
                answer = n1 * n2;
                if (answer % 2 == 0)
                {
                    evenOrOdd = " - even";
                }
                else
                {
                    evenOrOdd = " - odd";
                }
                Console.WriteLine($"{n1} {operators} {n2} = {answer}{evenOrOdd}");
            }
            else if (operators == "/")
            {  
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                answer = n1 * 1.0 / n2;
                Console.WriteLine($"{n1} {operators} {n2} = {answer}");
            }
            else if (operators == "%")
            {  
                if (n2 == 0)
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                    return;
                }
                answer = n1 % n2;
                Console.WriteLine($"{n1} {operators} {n2} = {answer}");

            }
          

          

        }
    }

      
}

