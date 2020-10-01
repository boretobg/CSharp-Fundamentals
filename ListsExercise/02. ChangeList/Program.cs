using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            string input = String.Empty;

            while (input != "end")
            {
                input = Console.ReadLine();            
                List<string> command = input.Split().ToList();

                if (command[0] == "Insert")
                {
                    list.Insert(int.Parse(command[2]), int.Parse(command[1]));
                }
                else if (command[0] == "Delete")
                {
                    list.RemoveAll(n => n == int.Parse(command[1]));
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
