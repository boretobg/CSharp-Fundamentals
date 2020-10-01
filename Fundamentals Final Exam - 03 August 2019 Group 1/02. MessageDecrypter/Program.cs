using System;
using System.Text.RegularExpressions;

namespace _02._MessageDecrypter
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"^([$%])(?<name>[A-Z][a-z]{3,})\1: \[(?<first>\d+)\]\|\[(?<second>\d+)\]\|\[(?<third>\d+)\]\|$";

            string input = String.Empty;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                bool isValid = false;
                input = Console.ReadLine();
                var matches = Regex.Matches(input, regex);

                string name = string.Empty;
                int first = 0;
                int second = 0;
                int third = 0;
                foreach (Match item in matches)
                {
                    name = item.Groups["name"].Value;
                    first = int.Parse(item.Groups["first"].Value);
                    second = int.Parse(item.Groups["second"].Value);
                    third = int.Parse(item.Groups["third"].Value);
                    isValid = true;
                }

                if (isValid)
                {
                    Console.WriteLine($"{name}: {(char)first}{(char)second}{(char)third}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
