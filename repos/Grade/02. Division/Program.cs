﻿using System;

namespace _02._Division
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number % 10 == 0 ? "The number is divisible by 10" : number % 7 == 0 ? "The number is divisible by 7" :
             number % 6 == 0 ? "The number is divisible by 6" : number % 3 == 0 ? "The number is divisible by 3" : number % 2 == 0 ? "The number is divisible by 2":"Not divisible");
        }
    }
}
