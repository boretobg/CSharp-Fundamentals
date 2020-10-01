using System;
using System.Collections.Generic;
using System.Numerics;

namespace _06.__ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            List<string> output = new List<string>();

            char temp = text[0];
            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == temp)
                {
                    continue;
                }
                else
                {
                    output.Add(temp.ToString());
                    temp = text[i];
                }
            }
            
            output.Add(temp.ToString());
            Console.WriteLine(string.Join("", output));
        }
    }
}
