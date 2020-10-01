using System;
using System.Linq;

namespace _04._CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string output = String.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                output += (char)(text[i] + 3);
            }

            Console.WriteLine(output);
        }
    }
}
