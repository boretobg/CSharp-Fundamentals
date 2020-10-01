using Microsoft.VisualBasic;
using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace _02._MessageTranslator
{
    class Program
    {
        static void Main(string[] args)
        {
            var regex = @"\!(?<cmd>[A-Z][a-z]{2,})\!\:\[(?<msg>[A-Za-z]{8,})\]";
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (Regex.IsMatch(input, regex))
                {
                    var matches = Regex.Matches(input, regex);
                    var cmd = "";
                    var msg = "";
                    foreach (Match item in matches)
                    {
                        cmd = item.Groups["cmd"].Value;
                        msg = item.Groups["msg"].Value;
                    }

                    var msgChar = new List<int>();
                    for (int j = 0; j < msg.Length; j++)
                    {
                        msgChar.Add((int)msg[j]);
                    }

                    Console.Write($"{cmd}: {string.Join(" ", msgChar)}");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The message is invalid");
                }
            }
        }
    }
}
