using System;
using System.Linq;

namespace _02._RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < words.Length; i++)
            {
                for (int j = 0; j < words[i].Length; j++)
                {
                    Console.Write(words[i]);
                }
            }
        }
    }
}
