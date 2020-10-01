using System;
using System.Linq;

namespace _04._TextFilter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(", ").ToArray();
            string text = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    text = text.Replace(words[i], new string('*', words[i].Count()));
                }
            }

            Console.WriteLine(text);
        }
    }
}
