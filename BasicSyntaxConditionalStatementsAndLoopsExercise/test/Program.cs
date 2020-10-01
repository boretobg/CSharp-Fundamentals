using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("REGISTER");
                Console.Write("Username: ");
                string nameRegister = Console.ReadLine();
                string passRegister = "";
                while (true)
                {
                    Console.Write("Password: ");
                    passRegister = Console.ReadLine();
                    if (passRegister.Length < 8)
                    {
                        Console.WriteLine("Password must be at least 8 symbols!");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine();
                Console.WriteLine("LOGIN");
                string nameLogin = "";
                while (true)
                {
                    Console.Write("Username: ");                    
                    nameLogin = Console.ReadLine();
                    if (nameLogin == nameRegister)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong username! Try again!");
                    }
                }

                string passLogin = "";
                while (true)
                {
                    Console.Write("Password: ");
                    passLogin = Console.ReadLine();
                    if (passLogin == passRegister)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong password! Try again!");
                    }
                }

                if (nameLogin == nameRegister && passLogin == passRegister)
                {
                    Console.WriteLine("Success!");
                    break;
                }
                else
                {
                    Console.WriteLine("Failed!");
                    break;
                }
            }
        }
    }
}
