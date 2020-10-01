using System;
using System.Linq;
using System.Collections.Generic;

namespace _02._ArrayModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split().ToArray();
                if (command.Contains("swap"))
                {
                    int firstIndex = int.Parse(command[1]);
                    int secondIndex = int.Parse(command[2]);
                    int firstNum = numbers[firstIndex];
                    int secondNum = numbers[secondIndex];
                    numbers.RemoveAt(firstIndex);
                    numbers.Insert(firstIndex, secondNum);
                    numbers.RemoveAt(secondIndex);
                    numbers.Insert(secondIndex, firstNum);
                }
                else if(command.Contains("multiply"))
                {
                    int first = numbers[int.Parse(command[1])];
                    int second = numbers[int.Parse(command[2])];
                    int sum = first * second;
                    numbers.RemoveAt(int.Parse(command[1]));
                    numbers.Insert(int.Parse(command[1]), sum);
                }
                else if (command.Contains("decrease"))
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i]--;
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
