using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] ordered = numbers.OrderByDescending(x => x).ToArray();
            int count = ordered.Length - 1;
            for (int i = 0; i < 3; i++)
            {
                Console.Write(ordered[i] + " ");
                if (i >= count)
                {
                    break;
                }
            }
        }
    }
}
