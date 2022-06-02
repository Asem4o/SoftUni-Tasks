using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = Console.ReadLine();
            int userNameLength = userName.Length - 1;
            string password = "";
            for (int value = userNameLength; value >= 0; value--)
            {
                password += userName[value];
            }
            int coutOfWrongPasswords = 0;
            string inputPasswords = Console.ReadLine();
            while (inputPasswords != password)
            {
                coutOfWrongPasswords++;
                if (coutOfWrongPasswords > 3)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                inputPasswords = Console.ReadLine();

            }
            if (inputPasswords == password)
            {
                Console.WriteLine($"User {userName} logged in.");
            }
        }
    }
}
