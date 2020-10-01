using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Random num = new Random();
            List<string> temp = new List<string>();
            int count = input.Length;

            for (int i = 0; i < count; i++)
            {
                int rnd = num.Next(0, input.Length);
                if (temp.Contains(input[rnd]))
                {
                    count++;
                    continue;
                }
                temp.Add(input[rnd]);
                Console.WriteLine(input[rnd]);
            }
        }
    }
}
