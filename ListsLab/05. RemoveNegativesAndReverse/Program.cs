using System;
using System.Linq;
using System.Collections.Generic;

namespace _05._RemoveNegativesAndReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            input.RemoveAll(n => n < 0);

            if (input.Count == 0)
            {
                Console.WriteLine("empty");
                return;
            }

            for (int i = input.Count - 1; i >= 0; i--)
            {
                Console.Write($"{input[i]} ");
            }
        }
    }
}
