using System;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());
            string letters ="";
            for (int fl = floors; fl > 0; fl--)
            {
                for (int ap = 0; ap <apartments; ap++)
                {
                    if (fl == floors)
                    {
                        letters = "L" + fl + ap + " ";
                   
                    }
                    else if (fl %2 == 0)
                    {
                        letters = "O" + fl + ap + " "; 
                    }
                    else
                    {
                        letters = "A" + fl + ap + " ";
                    }
                    Console.Write(letters);

                }
                Console.WriteLine();
            }
           
            
          
            
        }
    }
}
