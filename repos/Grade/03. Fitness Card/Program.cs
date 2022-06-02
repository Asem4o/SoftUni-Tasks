using System;

namespace _03._Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = double.Parse(Console.ReadLine());
            string gender = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();
            double Gym = 0;
            double Boxing = 0;
            double Yoga = 0; 
            double Zumba = 0; 
            double Dances = 0; 
            double Pilates = 0; 
            if (gender =="m")
            {
                Gym = 42;
                Boxing = 41;
                Yoga =45;
                Zumba = 34;
                Dances = 51;
                Pilates = 39;
                if (age<=19 )
                {
                    Gym    *=0.8 ;
                    Boxing *=0.8;
                    Yoga   *=0.8;
                    Zumba  *=0.8;
                    Dances *=0.8;
                    Pilates*=0.8;
                }

            }
            else if (gender =="f")
            {
                Gym = 35;
                Boxing = 37;
                Yoga = 42;
                Zumba = 31;
                Dances = 53;
                Pilates = 37;
                if (age <= 19)
                {
                    Gym *= 0.8;
                    Boxing *= 0.8;
                    Yoga *= 0.8;
                    Zumba *= 0.8;
                    Dances *= 0.8;
                    Pilates *= 0.8;
                }
            }
            if (sport == "Gym" && sum>=Gym)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}."); 
            }
            else if (sport =="Gym" && sum <Gym)
            {
                Console.WriteLine($"You don't have enough money! You need ${Gym - sum:f2} more.");
            }
            if (sport == "Boxing" && sum >Boxing)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (sport == "Gym" && sum < Boxing)
            {
                Console.WriteLine($"You don't have enough money! You need ${Boxing-sum:f2} more.");
            }
   
            if (sport == "Yoga" && sum > Yoga)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (sport == "Yoga" && sum <Yoga)
            {
                Console.WriteLine($"You don't have enough money! You need ${Yoga-sum:f2} more.");
            }
         
            if (sport == "Zumba" && sum >Zumba)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (sport == "Zumba" && sum < Zumba)
            {
                Console.WriteLine($"You don't have enough money! You need ${Zumba- sum:f2} more.");
            }
          
            if (sport == "Dances" && sum >Dances)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (sport == "Dances" && sum < Dances)
            {
                Console.WriteLine($"You don't have enough money! You need ${Dances- sum:f2} more.");
            }
           
            if (sport == "Pilates" && sum >Pilates)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else if (sport == "Pilates" && sum <Pilates)
            {
                Console.WriteLine($"You don't have enough money! You need ${Pilates-sum:f2} more.");
            }
          
        }
    }
}
