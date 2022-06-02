using System;

namespace _09._Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstInput = char.Parse(Console.ReadLine());
            char secondInput = char.Parse(Console.ReadLine());
            char thirdtInput = char.Parse(Console.ReadLine());
           
            Console.WriteLine($"{firstInput}{secondInput}{thirdtInput}");
        }
    }
}
