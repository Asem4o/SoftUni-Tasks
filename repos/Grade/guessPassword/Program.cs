using System;

namespace guessPassword
{
    class Program
    {
        static void Main(string[] args)
        {
            string passWord = Console.ReadLine();
            if (passWord == "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
