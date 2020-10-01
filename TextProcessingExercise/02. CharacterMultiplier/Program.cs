using System;
using System.Linq;
using System.Runtime.Versioning;

namespace _02._CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Console.WriteLine(CharacterMultiplier(input[0], input[1]));
        }

        static int CharacterMultiplier(string first, string second)
        {
            int result = 0;

            string longest = String.Empty;
            string shortest = String.Empty;

            if (first.Length > second.Length)
            {
                longest = first;
                shortest = second;
            }
            else
            {
                longest = second;
                shortest = first;
            }

            for (int i = 0; i < shortest.Length; i++)
            {
                result += shortest[i] * longest[i];
            }

            for (int i = shortest.Length; i < longest.Length; i++)
            {
                result += longest[i];
            }
            return result;
        }
    }
}
