using System;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace _01._WarriorsQuest
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();
            while (input != "For Azeroth")
            {
                var line = input.Split();
                if (line.Contains("GladiatorStance"))
                {
                    message = message.ToUpper();
                    Console.WriteLine(message);
                }
                else if (line.Contains("DefensiveStance"))
                {
                    message = message.ToLower();
                    Console.WriteLine(message);
                }
                else if (line.Contains("Dispel"))
                {
                    int index = int.Parse(line[1]);
                    string letter = line[2];
                    if (message.Length > index)
                    {
                        StringBuilder sb = new StringBuilder(message);
                        sb.Remove(index, 1);
                        message = sb.ToString();
                        message = message.Insert(index, letter);
                        Console.WriteLine("Success!");
                        input = Console.ReadLine();
                        continue;
                    }
                    Console.WriteLine("Dispel too weak.");
                }
                else if (line.Contains("Change"))
                {                             
                    string first = line[2];
                    string second = line[3];
                    int startIndex = message.IndexOf(first);
                    if (message.Contains(first))
                    {
                        message = message.Remove(startIndex, first.Length);
                        message = message.Insert(startIndex, second);
                        Console.WriteLine(message);
                    }
                }
                else if (line.Contains("Remove"))
                {
                    string toRemove = line[2];
                    int index = message.IndexOf(toRemove);
                    if (message.Contains(toRemove))
                    {
                        message = message.Remove(index, toRemove.Length);
                        Console.WriteLine(message);
                    }
                }
                else
                {
                    Console.WriteLine("Command doesn't exist!");
                }
                input = Console.ReadLine();
            }
        }
    }
}
