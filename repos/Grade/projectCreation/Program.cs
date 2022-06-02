using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projectCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfArchitect = Console.ReadLine();
            int countOfProject = int.Parse(Console.ReadLine());
            int neededHours = countOfProject * 3;
            Console.WriteLine($"The architect {nameOfArchitect} will need {neededHours} hours to complete {countOfProject} project/s. ");

            

        }
    }
}
