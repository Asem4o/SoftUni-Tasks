using System;

namespace timePlus15min
{
    class Program
    {
        static void Main(string[] args)
        {
            //input
            int hours = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int oneHours = hours;
            int moreMin = min + 15;
            if (hours<=22 && moreMin>=60 )
            {
                oneHours += 1;
                moreMin = moreMin - 60;
            }
            else if (hours >=23 && moreMin>=60 )
            {
                oneHours = oneHours - oneHours;
                moreMin = moreMin - 60;
            }
            Console.WriteLine(oneHours + ":" + moreMin.ToString("00"));
        }
    }
}
