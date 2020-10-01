using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string word = "";
            int lenght = input.Length;

            for (int i = lenght; i >= 1; lenght--)
            {
                word += lenght;
                Console.WriteLine(word);
            }
        }
    }
}
