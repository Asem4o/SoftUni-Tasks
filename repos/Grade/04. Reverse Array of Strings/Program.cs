using System;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length/2; i++)
            {
                string frontElements = input[i];
                string backElements = input[(input.Length - 1)-i];
                string tempElements = frontElements;
                input[i] = backElements;
                input[(input.Length - 1) - i] = tempElements;
            }
            Console.WriteLine(string.Join(" ",input));
          
        }
    }
}
