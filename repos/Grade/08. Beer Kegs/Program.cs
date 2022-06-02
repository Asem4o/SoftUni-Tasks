using System;

namespace _08._Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLine = int.Parse(Console.ReadLine());
            double currentVolum = double.MinValue;
            string freeString = "";
            for (int i = 0; i < nLine; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int hight = int.Parse(Console.ReadLine());
                double volume = Math.PI * Math.Pow(radius, 2) * hight;
                 
                if (volume > currentVolum)
                {              
                    currentVolum = volume;
                    freeString = model;
                }
            
            }
            Console.WriteLine(freeString);
        }
    }
}
