using System;

namespace BigestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;
            while (input !="Stop")
            {
                int answerInput =int.Parse(input);
                if (answerInput >max)
                {
                    max = answerInput;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
