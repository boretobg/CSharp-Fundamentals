using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._ListOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = String.Empty;

            while (input != "End")
            {
                input = Console.ReadLine();
                List<string> command = input.Split().ToList();

                if (command[0] == "Add")
                {
                    numbers.Add(int.Parse(command[1]));
                }
                else if (command[0] == "Remove")
                {
                    if (int.Parse(command[1]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.RemoveAt(int.Parse(command[1]));
                }
                else if (command[0] == "Insert")
                {
                    if (int.Parse(command[2]) >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }
                    numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Shift")
                {
                    if (command[1] == "left")
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++) //1 2 3 4 5
                        {
                            numbers.Add(numbers[0]);
                            numbers.RemoveAt(0);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < int.Parse(command[2]); i++)
                        {
                            numbers.Insert(0, numbers[numbers.Count - 1]);
                            numbers.RemoveAt(numbers.Count - 1);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
