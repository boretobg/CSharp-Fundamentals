using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> input = new List<string>();

            for (int i = 0; i < n; i++)
            {
                input.Add(Console.ReadLine());
            }

            input.Sort();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{i + 1}.{input[i]}");
            }
        }
    }
}
