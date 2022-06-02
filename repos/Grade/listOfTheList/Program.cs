using System;
using System.Collections.Generic;

namespace listOfTheList
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var list = new Dictionary<string, int>();
            list.Add("red", 5);
            list.Add("orange", 10);
            list.Add("yellow", 15);
            list.Add("white", 20);
            Console.WriteLine(list.GetValueOrDefault(input));
           
        }
    }
}
