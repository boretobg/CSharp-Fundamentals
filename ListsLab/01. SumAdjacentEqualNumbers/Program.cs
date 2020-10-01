using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();  //3 3 6 1

            for (int i = 0; i < list.Count; i++)
            {
                if (i + 1 >= list.Count)
                {
                    break;
                }

                if (list[i] == list[i + 1])
                {
                    list[i + 1] += list[i];
                    list.RemoveAt(i);
                    i = -1;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
