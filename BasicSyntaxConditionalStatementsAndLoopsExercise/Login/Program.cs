using System;

namespace Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string reverse = "";
            int length = 0;

            string username = Console.ReadLine();

            length = username.Length - 1;
            while (length >= 0)
            {
                reverse = reverse + username[length];
                length--;
            }

            string password = "";
            int tries = 0;
            while (true)
            {
                password = Console.ReadLine();
                tries++;
                if (password == reverse)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (tries >= 4)
                {
                    Console.WriteLine($"User {username} blocked.");
                    break;
                }
                Console.WriteLine($"Incorrect password. Try again.");
            }

        }
    }
}
