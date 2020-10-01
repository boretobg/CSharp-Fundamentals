using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._HouseParty
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //-	"{name} is going -"{name} is not going!"
            List<string> names = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string command = Console.ReadLine();
                List<string> cmd = command.Split().ToList();

                if (cmd[2] == "going!")
                {
                    if (names.Contains(cmd[0]))
                    {
                        Console.WriteLine($"{cmd[0]} is already in the list!");
                        continue;
                    }
                    names.Add(cmd[0]);
                }
                else if (cmd[2] == "not")
                {
                    if (names.Contains(cmd[0]))
                    {
                        names.Remove(cmd[0]);
                        continue;
                    }
                    Console.WriteLine($"{cmd[0]} is not in the list!");
                }
            }

            for (int i = 0; i < names.Count; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
