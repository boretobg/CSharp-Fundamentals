using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace _02._BossRysh
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string regex = @"\|(?<name>[A-Z]{3,})\|:#(?<title>[A-Za-z]+ [A-Za-z]+)#";
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, regex))
                {
                    var matches = Regex.Matches(input, regex);
                    foreach (Match item in matches)
                    {
                        var name = item.Groups["name"].Value;
                        var title = item.Groups["title"].Value;

                        Console.WriteLine($"{name}, The {title}");
                        Console.WriteLine($">> Strength: {name.Length}");
                        Console.WriteLine($">> Armour: {title.Length}");
                    }
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }
            }
        }
    }
}
