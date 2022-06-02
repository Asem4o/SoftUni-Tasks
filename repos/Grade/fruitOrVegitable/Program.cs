using System;

namespace fruitOrVegitable
{
    class Program
    {
        static void Main(string[] args)
        {
            string pr = Console.ReadLine();

            if (pr == "banana" || pr == "apple" || pr == "kiwi" || pr == "cherry" || pr == "lemon" || pr == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (pr == "tomato" || pr == "cucumber" || pr == "pepper" || pr == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
            
        }
    }
}
