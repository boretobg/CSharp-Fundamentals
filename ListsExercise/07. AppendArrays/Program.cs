using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._AppendArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var output = new List<string>();
            List<string> numbers = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                var temp = numbers[i].Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                for (int j = 0; j < temp.Count; j++)
                {
                    output.Add(temp[j]);
                }
            }
            Console.Write(string.Join(" ", output));

        }
    }
}
