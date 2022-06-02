using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int divideNumber = int.Parse(Console.ReadLine());
            int multiplyNumber = int.Parse(Console.ReadLine());

            int sumNums = firstNumber + secondNumber;
            int division = sumNums / divideNumber;
            int multyplyNumbers = division * multiplyNumber;
            Console.WriteLine(multyplyNumbers);
        }
    }
}
