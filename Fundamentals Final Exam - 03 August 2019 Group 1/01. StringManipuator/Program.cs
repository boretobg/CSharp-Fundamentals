using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._StringManipuator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var text = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                text.Add(input[i].ToString());
            }

            input = Console.ReadLine();
            while (input != "End")
            {
                string[] cmd = input.Split().ToArray();
                if (cmd[0] == "Translate")
                {
                    for (int i = 0; i < text.Count; i++)
                    {
                        if (text[i] == cmd[1])
                        {
                            text[i] = cmd[2];
                        }
                    }
                    Console.WriteLine(string.Join("", text));
                }
                else if (cmd[0] == "Includes")
                {
                    if (text.Contains(cmd[1]))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd[0] == "Start")
                {
                    int n = cmd[1].Count();
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < n; i++)
                    {
                        sb.Append(text[i]);
                    }
                    if (sb.ToString() == cmd[1])
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (cmd[0] == "Lowercase")
                {
                    for (int i = 0; i < text.Count; i++)
                    {
                        text[i] = text[i].ToLower();
                    }
                    Console.WriteLine(string.Join("", text));
                }
                else if (cmd[0] == "FindIndex")
                {
                    string temp = string.Join("", text);
                    Console.WriteLine(temp.LastIndexOf(cmd[1]));
                }
                else if (cmd[0] == "Remove")
                {
                    text.RemoveRange(int.Parse(cmd[1]), int.Parse(cmd[2]));
                    Console.WriteLine(string.Join("", text));
                }
                input = Console.ReadLine();
            }
        }
    }
}
