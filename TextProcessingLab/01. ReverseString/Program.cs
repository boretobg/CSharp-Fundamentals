using System;

namespace _01._ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            while (input != "end")
            {
                Console.Write(input + " = ");
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    Console.Write(input[i]);
                }
                Console.WriteLine();

                input = Console.ReadLine();
            }
        }
    }
}
