using System;
using System.Linq;

namespace _01._Nikulden_sCharity
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string line = Console.ReadLine();
            while (line != "Finish")
            {
                string[] cmd = line.Split().ToArray();
                if (cmd.Contains("Replace"))
                {
                    input = input.Replace(cmd[1], cmd[2]);
                    Console.WriteLine(input);
                }  
                else if (cmd.Contains("Cut")) 
                {
                    int start = int.Parse(cmd[1]);
                    int end = int.Parse(cmd[2]);
                    if ((start <= input.Length && start >= 0) && (end <= input.Length && end >= 0))
                    {
                        input = input.Remove(int.Parse(cmd[1]), int.Parse(cmd[2]));
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                else if (cmd.Contains("Upper"))
                {
                    input = input.ToUpper();
                    Console.WriteLine(input);
                }
                else if (cmd.Contains("Lower"))
                {
                    input = input.ToLower();
                    Console.WriteLine(input);
                }
                else if (cmd.Contains("Check"))
                {
                    if (input.Contains(cmd[1]))
                    {
                        Console.WriteLine($"Message contains {cmd[1]}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {cmd[1]}");
                    }
                }
                else if (cmd.Contains("Sum"))
                {
                    int start = int.Parse(cmd[1]);
                    int end = int.Parse(cmd[2]);
                    if ((start <= input.Length && start >= 0) && (end <= input.Length && end >= 0))
                    {
                        int sum = 0;
                        for (int j = start; j <= end; j++)
                        {
                            sum += (int)input[j];
                        }
                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indexes!");
                    }
                }
                line = Console.ReadLine();
            }
        }
    }
}
