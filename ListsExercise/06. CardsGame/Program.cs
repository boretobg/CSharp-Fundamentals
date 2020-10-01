using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace _06._CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> second = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> firstSum = new List<int>();
            List<int> secondSum = new List<int>();
            int count = 0;
            bool isSecond = false;
            bool isFirst = false;

            while (true)
            {
                if (first.Count == 0)
                {
                    isSecond = true;
                    break;
                }
                else if (second.Count == 0)
                {
                    isFirst = true;
                    break;
                }

                if (first[count] == second[count])
                {
                    first.RemoveAt(count);
                    second.RemoveAt(count);
                }
                else if (first[count] > second[count])
                {
                    first.Add(first[count]);
                    first.Add(second[count]);
                    first.RemoveAt(count);
                    second.RemoveAt(count);
                }
                else
                {
                    second.Add(second[count]);
                    second.Add(first[count]);
                    second.RemoveAt(count);
                    first.RemoveAt(count);
                }
            }

            if (isFirst)
            {
                Console.WriteLine($"First player wins! Sum: {first.Sum()}");
            }
            else if (isSecond)
            {
                Console.WriteLine($"Second player wins! Sum: {second.Sum()}");
            }

        }
    }
}
