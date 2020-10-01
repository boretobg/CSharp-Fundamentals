using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._GaussTrick
{
    class Program
    {
        static void Main(string[] args)
        {         
            List<double> list = Console.ReadLine().Split().Select(double.Parse).ToList();
            List<double> output = new List<double>();
            int count = 0;

            for (int i = 0; i <= list.Count / 2; i++)
            {
                count = list.Count;
                if (i == list.Count / 2)
                {
                    if (list.Count % 2 == 1)
                    {
                        output.Add(list[i]);
                    }
                    break;
                }
                output.Add(list[i] + list[list.Count - i - 1]); 
            }

            Console.WriteLine(string.Join(" ", output));
        }
    }
}
