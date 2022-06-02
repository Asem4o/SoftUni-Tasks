using System;

namespace whilEE
{
    class Program
    {
        static void Main(string[] args)
        {
          
            double count = 0;
            string text = Console.ReadLine();
            while (text != "NoMoreMoney")
            {
                int currentText = int.Parse(text);
                text = Console.ReadLine(); 

            }
            Console.WriteLine(text);
        }
    }
}
