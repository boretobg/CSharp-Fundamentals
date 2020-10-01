using System;
using System.Linq;

namespace _01_
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "Travel")
            {
                string[] cmd = input.Split(":");
                if (cmd.Contains("Add Stop"))
                {
                    int index = int.Parse(cmd[1]);
                    int lenght = cmd[2].Length;
                    if (index + lenght <= stops.Length)
                    {
                        stops = stops.Insert(index, cmd[2]);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmd.Contains("Remove Stop"))
                {
                    int startIndex = int.Parse(cmd[1]);
                    int endIndex = int.Parse(cmd[2]);
                    int count = endIndex - startIndex;
                    if ((startIndex <= stops.Length - 1 && startIndex >= 0) && (endIndex <= stops.Length - 1 && endIndex >= 0))
                    {
                        stops = stops.Remove(startIndex, count + 1);
                    }
                    Console.WriteLine(stops);
                }
                else if (cmd.Contains("Switch"))
                {
                    if (stops.Contains(cmd[1]))
                    {
                        if (stops.Contains(cmd[1]))
                        {
                            stops = stops.Replace(cmd[1], cmd[2]);
                        }
                    }
                    Console.WriteLine(stops);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
