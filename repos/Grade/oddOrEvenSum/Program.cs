using System;

namespace oddOrEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double suma = 0; 
            double sumb = 0; 
            for (int i = 1; i <= n; i++)
            {
                int a =int.Parse(Console.ReadLine());
                     if (i%2==0)
                     {
                    suma += a;

                     }
                else
                {
                    sumb += a;
                }
           
            }
            if (suma==sumb)
            {
                Console.WriteLine($"Yes");
                Console.WriteLine($"Sum = {suma}");
            }
            else
            {
                double gege =Math.Abs( sumb - suma);
                Console.WriteLine($"No");
                Console.WriteLine($"Diff = {gege}");
            }
          
        }
       
    }
}
