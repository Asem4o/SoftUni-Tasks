using System;

namespace _01._Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine(age <= 2 ? "baby" : age >= 3 && age <= 13 ? "child" :
            age >= 14 && age <= 19 ? "teenager" : age >= 20 && age <= 65 ? "adult" : "elder");
                  

            //if (age <=2 && age >=0)
            //{
            //    Console.WriteLine("baby");
            //}
            //else if (age >=3 && age <=13)
            //{
            //    Console.WriteLine("child");
            //}
            //else if (age >=14 && age <=19)
            //{
            //    Console.WriteLine("teenager");
            //}
            //else if (age >=20 && age <=65)
            //{
            //    Console.WriteLine("adult");
            //}
            //else if (age >=66)
            //{
            //    Console.WriteLine("elder");
            //}
        }
    }
}
