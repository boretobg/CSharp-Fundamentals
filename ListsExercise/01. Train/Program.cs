using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int max = int.Parse(Console.ReadLine());
            string text = String.Empty;

            while (true)
            {
                text = Console.ReadLine();
                if (text == "end")
                {
                    break;
                }

                List<string> input = text.Split().ToList();

                if (input[0] == "Add")
                {
                    wagons.Add(int.Parse(input[1]));
                    continue;
                }

                for (int i = 0; i < wagons.Count; i++)
                {
                    if (int.Parse(input[0]) + wagons[i] <= max)
                    {
                        wagons[i] += int.Parse(input[0]);
                        break;
                    }
                }

            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
