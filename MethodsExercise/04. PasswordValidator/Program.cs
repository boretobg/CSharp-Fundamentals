using System;

namespace _04._PasswordValidator
{
    class Program
    {
        static void Main(string[] args)              // NOT FINISHED
        {
            string password = Console.ReadLine();
            PasswordRangeRule(password);
            PasswordDigitRule(password);
            PasswordLettersAndDigitsRule(password);
        }

        static void PasswordRangeRule(string password)
        {
            if (password.Length < 6 || password.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }

        static void PasswordLettersAndDigitsRule(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!(password[i] >= 48 && password[i] <= 57 || 
                    password[i] >= 64 && password[i] <= 90 || 
                    password[i] >= 97 && password[i] <= 122))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                }
            }
        }

        static void PasswordDigitRule(string password)
        {
            int count = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 48 && password[i] <= 57)
                {
                    count++;
                }
            }

            if (count < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
        }
    }
}
