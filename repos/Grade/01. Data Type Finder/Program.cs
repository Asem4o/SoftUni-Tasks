using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            float valueOfFloat = 0.0f;
            char valueOfChar;
            bool valueOfBool;
            while (input !="END")
            {
                if (int.TryParse(input,out number) )
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out valueOfFloat))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out valueOfChar))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out valueOfBool))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }
                input = Console.ReadLine();
            }
        }
    }
}
