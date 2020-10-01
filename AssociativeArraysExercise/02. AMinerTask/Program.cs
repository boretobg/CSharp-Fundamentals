using System;
using System.Collections.Generic;
using System.Threading;

namespace _02._AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> ores = new Dictionary<string, int>();

            string input = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            while (true)
            {
                if (ores.ContainsKey(input))
                {
                    ores[input] += quantity;
                }
                else
                {
                    ores.Add(input, quantity);
                }
                
                input = Console.ReadLine();
                if (input == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
            }

            foreach (var item in ores)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
