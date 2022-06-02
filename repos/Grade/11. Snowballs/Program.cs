using System;
using System.Numerics;

namespace _11._Snowballs
{
    class Program
    {
        static void Main(string[] args)
        {
            int snowBall = int.Parse(Console.ReadLine());
            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            int snowBallQulity = 0;
            BigInteger bestSnawBall = int.MinValue;
            string bestBallFormula = "";
            for (int i = 0; i < snowBall; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQulity = int.Parse(Console.ReadLine());
                BigInteger currentSnowballValue = snowBallSnow / snowBallTime;
                snowBallValue = BigInteger.Pow(currentSnowballValue, snowBallQulity);
                if (snowBallValue > bestSnawBall)
                {
                    bestSnawBall = snowBallValue;
                    bestBallFormula = $"{snowBallSnow} : {snowBallTime} = {snowBallValue} ({snowBallQulity})";
                }
            }
            Console.WriteLine(bestBallFormula);
          
        }
    }
}
