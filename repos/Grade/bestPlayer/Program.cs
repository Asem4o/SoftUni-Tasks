using System;

namespace bestPlayer
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int counter = 0;
            string name = "";
            bool isTrue = false;
            while (input != "END")
            {

                int goals = int.Parse(Console.ReadLine());
                
                

                if (goals > counter)
                {
                    counter = goals;
                    name = input;

                }
               
                if (counter >= 3)
                {
                    isTrue = true;
                }
                if (counter >= 10)
                {
                    Console.WriteLine($"{name} is the best player!");
                    Console.WriteLine($"He has scored {counter} goals and made a hat-trick !!!");
                    return;
                }
               
                input = Console.ReadLine();
                
            }
            
            if (isTrue)
            {
                Console.WriteLine($"{name} is the best player!");
                Console.WriteLine($"He has scored {counter} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{name} is the best player!");
                Console.WriteLine($"He has scored {counter} goals.");
            }

        }

    }
}
