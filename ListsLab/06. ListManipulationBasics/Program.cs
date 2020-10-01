using System;
using System.Linq;
using System.Collections.Generic;

namespace _06._ListManipulationBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = String.Empty;

            while (true)
            {
                command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }
                List<string> cmd = command.Split().ToList();

                switch (cmd[0])
                {
                    case "Add":
                        numbers.Add(int.Parse(cmd[1]));
                        break;
                    case "Remove":
                        numbers.Remove(int.Parse(cmd[1]));
                        break;
                    case "RemoveAt":
                        numbers.RemoveAt(int.Parse(cmd[1]));
                        break;
                    case "Insert":
                        numbers.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
