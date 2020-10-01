using System;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text.RegularExpressions;

namespace _02._MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\+359([- ])2\1\d{3}\1\d{4}\b";
            var input = Console.ReadLine();

            MatchCollection matches = Regex.Matches(input, regex);
            var matchesArray = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

            Console.WriteLine(String.Join(", ", matchesArray));
        }
    }
}
