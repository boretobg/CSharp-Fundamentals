using System;
using System.Collections.Generic;
using System.Linq;

namespace FundamentalsFinalExam04._04
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> code = new List<string>();

            for (int i = 0; i < input.Length; i++)
            {
                code.Add(input[i].ToString());
            }

            input = Console.ReadLine();
            while (input != "Generate")
            {
                string[] command = input.Split(">>>").ToArray();

                if (command[0] == "Contains")
                {
                    int count = 0;
                    List<string> contains = new List<string>();
                    string word = command[1];
                    for (int i = 0; i < command[1].Length; i++)
                    {
                        contains.Add(word[i].ToString());
                    }

                    for (int i = 0; i < contains.Count; i++)
                    {
                        if (code.Contains(contains[i]))
                        {
                            count++;
                        }
                    }

                    if (count == contains.Count)
                    {
                        Console.WriteLine($"{string.Join("", code)} contains {word}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }

                if (command[0] == "Flip")
                {
                    int first = int.Parse(command[2]);
                    int last = int.Parse(command[3]);

                    if (command[1] == "Upper")
                    {
                        for (int i = first; i < last; i++)
                        {
                            code.Insert(i, code[i].ToUpper());
                            code.RemoveAt(i + 1);
                        }
                    }
                    else
                    {
                        for (int i = first; i < last; i++)
                        {
                            code.Insert(i, code[i].ToLower());
                            code.RemoveAt(i + 1);
                        }
                    }

                    Console.WriteLine(string.Join("", code));
                }

                if (command[0] == "Slice")
                {
                    int first = int.Parse(command[1]);
                    int last = int.Parse(command[2]);

                    for (int i = first; i <= last - 1; i++)
                    {
                        code.RemoveAt(first);
                    }

                    Console.WriteLine(string.Join("", code));
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {string.Join("", code)}");
        }
    }
}
