using System;
using System.Collections.Generic;

namespace _03._WordSynonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> words = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();

                if (words.ContainsKey(word))
                {
                    words[word] += " " + synonim;
                }
                else
                {
                    words.Add(word, synonim);
                }
            }

            foreach (var item in words)
            {
                string[] synonimsOutput = item.Value.Split();
                Console.WriteLine($"{item.Key} - {string.Join(", ", synonimsOutput)}");
            }
        }
    }
}
