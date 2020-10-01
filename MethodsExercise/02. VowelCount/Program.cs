using System;
using System.Linq;

namespace _02._VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine().ToLower();
            char[] vowels = new char[] {'a', 'e', 'o', 'i', 'u' };
            VowelCount(text, vowels);
        }

        static void VowelCount(string text, char[] vowels)
        {
            int count = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (vowels.Contains(text[i]))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
