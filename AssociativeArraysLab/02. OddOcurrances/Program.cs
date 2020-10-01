using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._OddOcurrances
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split().ToArray();
            Dictionary<string, int> items = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (items.ContainsKey(input[i]))
                {
                    items[input[i]] += 1;
                }
                else
                {
                    items.Add(input[i], 1);
                }
            }

            foreach (var occurance in items)
            {
                if (occurance.Value % 2 != 0)
                {
                    Console.Write(occurance.Key + " ");
                }
            }
        }
    }
}
