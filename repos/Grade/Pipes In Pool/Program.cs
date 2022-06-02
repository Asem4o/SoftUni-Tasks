using System;

namespace Pipes_In_Pool
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double firstPipe = p1 * h;
            double secondPipe = p2 * h;
            double all = firstPipe + secondPipe;
            if (all < volume)
            {
                double volumeInProcents = (all / volume) * 100;
                double p1InProcents = (firstPipe / all) * 100;
                double p2InProcents = (secondPipe / all) * 100;
                Console.WriteLine($"The pool is {volumeInProcents:f2}% full. Pipe 1: {p1InProcents:f2}%. Pipe 2: {p2InProcents:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {h:f2} hours the pool overflows with {all - volume:f2} liters.");
            }

        }
    }
}
