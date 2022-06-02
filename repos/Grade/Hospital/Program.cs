using System;

namespace Hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int current = 0;
            int doctors = 7;
            int treated = 0;
            int unTreated = 0;
            int one = 0;
            for (int i = 1; i <= days; i++)
            {
                current = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    if (unTreated> treated)
                    {
                        doctors += 1;
                        one += 1;
                    }
                }
                if (current >= doctors)
                {                
                    current -= doctors;
                    treated += doctors;
                    unTreated += current;  
                }
                else
                {
                    treated += one;
                }

            }
            Console.WriteLine($"Treated patients: {treated}.");
            Console.WriteLine($"Treated patients: {unTreated}.");
        }
    }

}

