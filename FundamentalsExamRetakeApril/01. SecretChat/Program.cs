using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> command = new List<string>();

            int count = 0;
            int countReverse = 0;

            List<string> text = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                text.Add(input[i].ToString());
            }

            while (true)
            {
                command = Console.ReadLine().Split(":|:").ToList();
                if (command[0] == "Reveal")
                {
                    break;
                }
                else if (command[0] == "InsertSpace")
                {
                    text.Insert(int.Parse(command[1]), " ");
                }
                else if (command[0] == "Reverse") //boybb  ybb
                {
                    string reverse = command[1]; //ybb
                    for (int j = 0; j < text.Count; j++)
                    {
                        if (text[j] == command[1][count].ToString())
                        {
                            countReverse++;
                            if (countReverse == reverse.Length)
                            {
                                for (int i = 0; i < reverse.Length; i++)
                                {
                                    text.Remove(text[j]);
                                    text.Add(text[j]);
                                }
                            }
                        }
                        count++;
                    }
                }
            }
        }
    }
}




