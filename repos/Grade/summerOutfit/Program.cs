using System;

namespace summerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int degrees = int.Parse(Console.ReadLine());
            string days = Console.ReadLine();
            string outfits = "";
            string shoes = "";

            if (degrees >=10 && degrees <=18)
            {
                if (days == "Morning")
                {
                    outfits = "Sweatshirt";
                    shoes = "Sneakers";
                    
                }
                else if (days == "Afternoon" || days == "Evening")
                {
                    outfits = "Shirt";
                    shoes = "Moccasins";
                   
                }
            }
            else if (degrees >18 && degrees <=24)
            {
                if (days == "Morning" || days == "Evening")
                {
                    outfits = "Shirt";
                    shoes = "Moccasins";
                    
                }
                else if (days == "Afternoon")
                {
                    outfits = "T-Shirt";
                    shoes = "Sandals";
                }
            }
            else if (degrees >=25)
            {
                if (days == "Morning")
                {
                    outfits = "T-Shirt";
                    shoes = "Sandals";
                }
                else if (days == "Afternoon")
                {
                    outfits = "Swim Suit";
                    shoes = "Barefoot";
                }
                else if (days == "Evening")
                {
                    outfits = "Shirt";
                    shoes = "Moccasins";
                }
            }
            Console.WriteLine($"It's {degrees} degrees, get your {outfits} and {shoes}.");
        }
    }
}
