using System;

namespace personalTitles
{
    class Program
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            string ganedr = Console.ReadLine();

            if (ganedr == "f")
            {
                if (age >=16)
                {
                    Console.WriteLine("Ms.");
                }
                else
                {
                    Console.WriteLine("Miss");
                }
            }
            else
            {
                if (age >=16)
                {
                    Console.WriteLine("Mr.");
                }
                else
                {
                    Console.WriteLine("Master");
                }

            }


        }
    }
}
