using System;

namespace gameName
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int num = 0;
            bool game = true;
            int value = 0;
            int counter = 0;
            int secPlayer = 0;
            string newName = "";
            string firstName = "";
            int gg = 0;
            while (game)
            {
              

                if (name == "Stop")
                {
                    break;
                }
               
                for (int i = 0; i <=name.Length; i++)
                {
                    

                    foreach (char name1 in name)
                    {
                        num = int.Parse(Console.ReadLine());
                        if (num == name1)
                        {
                            value += 10;
                        }
                        else if (num != name1)
                        {
                            value += 2;
                        }
                       
                    }          
                    
                    break;
                }
                secPlayer = value - counter;
                if (value >1 && counter ==0)
                {
                    firstName = name;
                    gg =2;
                }
                newName = name;
                name = Console.ReadLine();
                
                counter = value;
                
            }
            if (value == counter && newName!=firstName  )
            {
                Console.WriteLine($"The winner is {newName} with {secPlayer} points!");
                return;
            }
            if (value <secPlayer && firstName==firstName )
            {
                Console.WriteLine($"The winner is {firstName} with {value - secPlayer} points!");
            }
          
            else
            {
                Console.WriteLine($"The winner is {newName} with {secPlayer} points!");
            }
           
           
            
        }
    }
}
