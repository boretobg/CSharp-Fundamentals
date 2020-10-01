using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace _02._DestinationMapper
{
    class Program
    {
        static void Main(string[] args)
        {               
            var regex = @"(\=|\/)(?<name>[A-Z][A-Za-z]{2,})\1";

            string input = Console.ReadLine();
            var list = new List<string>();
            int count = 0;

            var matches = Regex.Matches(input, regex);
            foreach (Match item in matches)
            {
                var match = item.Groups["name"].Value;
                count += match.Length;
                list.Add(match);
            }
            
            Console.WriteLine($"Destinations: {string.Join(", ", list)}");
            Console.WriteLine($"Travel Points: {count}");
        }
    }
}
