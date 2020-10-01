using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList(); //1 2 2 4 2 2 2 9
            List<int> command = Console.ReadLine().Split().Select(int.Parse).ToList(); //4 2
            int count = 0;

            for (int i = 0; i < numbers.Count; i++) 
            {
                count++;
                if (numbers[i] == command[0])
                {
                    for (int j = 0; j < command[1] * 2 + 1; j++)
                    {
                        if (count + command[1] >= numbers.Count)
                        {
                            numbers.RemoveAt(numbers.Count - 1);
                            continue;
                        }
                        numbers.RemoveAt(count + command[1]);
                        count--;
                    }
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
