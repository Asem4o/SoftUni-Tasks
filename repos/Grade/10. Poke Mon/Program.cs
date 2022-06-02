using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            int thirdValue = int.Parse(Console.ReadLine());
            int counter = 0;
            decimal originalValue = Convert.ToDecimal(firstValue)/2;
            while (firstValue >=secondValue )
            {
                counter++;
                firstValue -= secondValue;
                 if (originalValue == firstValue)
                 {
                    if (thirdValue == 0)
                    {
                        continue;
                    }
                    firstValue /= thirdValue;
                 }
                
            }
           
            Console.WriteLine(firstValue);
            Console.WriteLine(counter);
        }
    }
}
