using System;

namespace _03._Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string itemToRemove = Console.ReadLine().ToLower();
            string word = Console.ReadLine();

            while (word.IndexOf(itemToRemove) != - 1)
            {
                word = word.Remove(word.IndexOf(itemToRemove), itemToRemove.Length);
            }

            Console.WriteLine(word);
        }
    }
}
