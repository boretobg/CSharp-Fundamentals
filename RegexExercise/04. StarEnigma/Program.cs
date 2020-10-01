using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _04._StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"[STARstar]";

            var attacked = new List<string>();
            var destroyed = new List<string>();

            string input = String.Empty;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                var inputList = new List<char>();
                for (int k = 0; k < input.Length; k++)
                {
                    inputList.Add(input[k]);
                }

                int count = Regex.Matches(input, regex).Count;

                string message = string.Empty;
                for (int j = 0; j < inputList.Count; j++)
                {
                    message += (char)(inputList[j] - count);
                }

                string secondRegex = @"@(?<name>[A-Z][a-z]+)\.?\d?:(?<population>\d+)!(?<type>[AD])!->(?<count>\d+)";

                var matches = Regex.Matches(message, secondRegex);
                var name = "";
                var type = "";
                foreach (Match match in matches)
                {
                    name = match.Groups["name"].Value;
                    type = match.Groups["type"].Value;
                }

                if (type == "A")
                {
                    attacked.Add(name);
                }
                else if (type == "D")
                {
                    destroyed.Add(name);
                }
            }

            attacked.Sort();
            Console.WriteLine($"Attacked planets: {attacked.Count}");
            for (int i = 0; i < attacked.Count; i++)
            {
                Console.WriteLine($"-> {attacked[i]}");
            }
            destroyed.Sort();
            Console.WriteLine($"Destroyed planets: {destroyed.Count}");
            for (int i = 0; i < destroyed.Count; i++)
            {
                Console.WriteLine($"-> {destroyed[i]}");
            }
        }
    }
}
