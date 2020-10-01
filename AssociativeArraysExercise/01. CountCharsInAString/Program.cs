using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._CountCharsInAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split().ToArray(); //abv abv abv
            Dictionary<char, int> letters = new Dictionary<char, int>();
            int count = 0;

            for (int i = 0; i < word.Length; i++)
            {
                string temp = word[i];
                for (int j = 0; j < temp.Length; j++)
                {
                    if (letters.ContainsKey(temp[j]))
                    {
                        count += 1;
                        letters[temp[j]] += count;
                    }
                    else
                    {
                        letters.Add(temp[j], 1);
                    }
                    count = 0;
                }
            }

            foreach (var item in letters)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
