using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml;

namespace _03._PlantDiscovery
{
    class Program
    {
        static void Main(string[] args)
        {
            var plants = new List<Plant>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                bool alreadyIn = false;
                string[] input = Console.ReadLine().Split("<->"); //"{plant}<->{rarity}"
                int rarity = int.Parse(input[1]);
                for (int j = 0; j < plants.Count; j++)
                {
                    if (plants[j].name == input[0])
                    {
                        plants[j].rarity = rarity;
                        alreadyIn = true;
                    }
                }
                if (alreadyIn)
                {
                    continue;
                }

                Plant plant = new Plant();
                plant.name = input[0];
                plant.rarity = rarity;
                plants.Add(plant);

            }

            string line = Console.ReadLine();
            while (line != "Exhibition")
            {
                string[] cmd = line.Split(": ");
                string[] cmd2 = cmd[1].Split(" - ");

                bool hasEntered = false;
                if (cmd.Contains("Rate"))
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        if (plants[i].name == cmd2[0])
                        {
                            hasEntered = true;
                            plants[i].rating += int.Parse(cmd2[1]);
                            plants[i].count++;
                        }
                    }                   
                    if (!hasEntered)
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd.Contains("Update"))
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        if (plants[i].name == cmd2[0])
                        {
                            hasEntered = true;
                            plants[i].rarity = int.Parse(cmd2[1]);
                        }
                    }
                    if (!hasEntered)
                    {
                        Console.WriteLine("error");
                    }
                }
                else if (cmd.Contains("Reset"))
                {
                    for (int i = 0; i < plants.Count; i++)
                    {
                        if (plants[i].name == cmd2[0])
                        {
                            hasEntered = true;
                            plants[i].rating = 0;
                        }
                    }
                    if (!hasEntered)
                    {
                        Console.WriteLine("error");
                    }
                }
                else
                {
                    Console.WriteLine("error");
                }

                line = Console.ReadLine();
            }

            for (int i = 0; i < plants.Count; i++)
            {
                plants[i].average = plants[i].rating / plants[i].count;
            }

            var sorted = plants.OrderByDescending(x => x.rarity).ThenByDescending(x => x.average).ToList();

            Console.WriteLine("Plants for the exhibition:");
            foreach (var item in sorted)
            {
                Console.WriteLine($"- {item.name}; Rarity: {item.rarity}; Rating: {item.average:f2}");
            }

        }
    }

    class Plant
    {
        public string name { get; set; }
        public int rarity { get; set; }
        public decimal rating { get; set; }
        public int count { get; set; }
        public decimal average { get; set; }
    }
}
