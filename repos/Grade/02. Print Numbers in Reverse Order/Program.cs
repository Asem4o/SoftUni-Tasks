﻿using System;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int[] numbers = new int[length];
            for (int i = 0; i < length; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbers[i] = number;
            }
            for (int i = numbers.Length -1; i >=0; i--)
            {
                Console.Write($"{numbers[i]} ");
            }
        }
    }
}
