using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace _03._MergingLists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> output = new List<int>();

            int count = second.Count;

            if (first.Count > second.Count)
            {
                count = first.Count;
            }

            for (int i = 0; i < count; i++)
            {
                if (i < first.Count)
                {
                    output.Add(first[i]);
                }

                if (i < second.Count)
                {
                    output.Add(second[i]);
                }
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
