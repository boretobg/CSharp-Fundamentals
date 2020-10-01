using System;
using System.Text.RegularExpressions;

namespace _01._MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex = @"\b[A-Z][a-z]+\s[A-Z][a-z]+\b";

            string input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + " ");
            }
        }
    }
}
