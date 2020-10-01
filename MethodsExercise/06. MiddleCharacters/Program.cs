using System;

namespace _06._MiddleCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            MiddleChar(word);
        }

        static void MiddleChar(string word)
        {
            if (word.Length % 2 == 0) 
            {
                Console.WriteLine($"{word[word.Length / 2 - 1]}{word[word.Length / 2]}");
            }
            else //abc
            {
                Console.WriteLine($"{word[word.Length / 2]}");
            }          
        }
    }
}
