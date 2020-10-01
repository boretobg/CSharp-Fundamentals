using System;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace _07._ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> current = numbers;
            string command = String.Empty;
            bool hasMade = false;

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
                        current.Add(int.Parse(cmd[1]));
                        hasMade = true;
                        break;
                    case "Remove":
                        current.Remove(int.Parse(cmd[1]));
                        hasMade = true;
                        break;
                    case "RemoveAt":
                        current.RemoveAt(int.Parse(cmd[1]));
                        hasMade = true;
                        break;
                    case "Insert":
                        current.Insert(int.Parse(cmd[2]), int.Parse(cmd[1]));
                        hasMade = true;
                        break;
                    case "Contains":
                        if (current.Contains(int.Parse(cmd[1])))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        for (int i = 0; i < current.Count; i++)
                        {
                            if (current[i] % 2 == 0)
                            {
                                Console.Write(current[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        for (int i = 0; i < current.Count; i++)
                        {
                            if (current[i] % 2 != 0)
                            {
                                Console.Write(current[i] + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        Console.WriteLine(current.Sum());
                        break;
                    case "Filter":
                        switch (cmd[1])
                        {
                            case "<":
                                for (int i = 0; i < current.Count; i++)
                                {
                                    if (current[i] < int.Parse(cmd[2]))
                                    {
                                        Console.Write(current[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">":
                                for (int i = 0; i < current.Count; i++)
                                {
                                    if (current[i] > int.Parse(cmd[2]))
                                    {
                                        Console.Write(current[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                for (int i = 0; i < current.Count; i++)
                                {
                                    if (current[i] >= int.Parse(cmd[2]))
                                    {
                                        Console.Write(current[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                for (int i = 0; i < current.Count; i++)
                                {
                                    if (current[i] <= int.Parse(cmd[2]))
                                    {
                                        Console.Write(current[i] + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
            }

            if (hasMade)
            {
                Console.WriteLine(string.Join(" ", current));
            }
        }
    }
}
