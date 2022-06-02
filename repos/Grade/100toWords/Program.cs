using System;

namespace _100toWords
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());//23
            int secondDigit = num % 10;
            int firstDigit = num / 10;

            string text = "";  

            switch (firstDigit)
            {
               
                case 2:
                    text = "twenty";
                    break;
                case 3:
                    text = "thirty";
                    break;
                case 4:
                    text = "forty";
                    break;
                case 5:
                    text = "fifty";
                    break;
                case 6:
                    text = "sixty";
                    break;
                case 7:
                    text = "seventy";
                    break;
                case 8:
                    text = "eighty";
                    break;
                case 9:
                    text = "ninety";
                    break;
                default:
                    break;
            }
            if (secondDigit !=0 && num > 20  )
            {
                text += " ";
                
            }
            switch (secondDigit)
            {
                case 1:
                    text += "one";
                    break;
                case 2:
                    text += "two";
                    break;
                case 3:
                    text += "three";
                    break;
                case 4:
                    text += "four";
                    break;
                case 5:
                    text += "five";
                    break;
                case 6:
                    text += "six";
                    break;
                case 7:
                    text += "seven";
                    break;
                case 8:
                    text += "eight";
                    break;
                case 9:
                    text += "nine";
                    break;
                default:
                    break;
            }
            if (num ==0)
            {
                text = "zero";
            }
            if (firstDigit ==1)
            {
                if (num == 10)
                {
                    text = "ten";
                }
                else if (num == 11)
                {
                    text = "eleven";
                }
                else if (num == 12)
                {
                    text = "twelve";
                }
                else if (num == 13)
                {
                    text = "thirteen";
                }
                else if (num == 15)
                {
                    text = "fifteen";
                }
                else
                {
                    text = text + "teen";
                }
            }
            
            if (num ==100)
            {
                text = "one hundred";
            }
            else if (num > 100 || num < 0)
            {
                text = "invalid number";
            }
           


            Console.WriteLine($"{text}");//nqma realnikoreni gege
        }
    }
}
