﻿using System;

namespace _04._Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int finalSum = 0;
            for (int i = 0; i < number; i++)
            {
                char digit = char.Parse(Console.ReadLine());
                finalSum += (int)digit;
            }
            Console.WriteLine($"The sum equals: {finalSum}");
        }
    }
}