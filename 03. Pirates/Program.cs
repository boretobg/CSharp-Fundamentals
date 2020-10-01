using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

namespace _03._Pirates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Destination> destinations = new List<Destination>();
            List<String> cities = new List<string>();

            string input = Console.ReadLine();
            while (input != "Sail")
            {
                List<string> list = input.Split("||").ToList();
                bool alreadyReceived = false;

                for (int i = 0; i < cities.Count; i++)
                {
                    if (list[0] == cities[i])
                    {
                        for (int j = 0; j < destinations.Count; j++)
                        {
                            if (destinations[j].city == cities[i])
                            {
                                destinations[j].population += int.Parse(list[1]);
                                destinations[j].gold += int.Parse(list[2]);
                                alreadyReceived = true;
                                break;
                            }
                        }
                    }
                }

                if (alreadyReceived)
                {
                    input = Console.ReadLine();
                    continue;
                }
                cities.Add(list[0]);

                Destination currDestination = new Destination(list[0], int.Parse(list[1]), int.Parse(list[2]));
                destinations.Add(currDestination);

                input = Console.ReadLine();
            }

            List<string> commands = new List<string>();

            input = Console.ReadLine();
            while (input != "End")
            {
                commands = input.Split("=>").ToList();
                string tempCity = commands[1];

                if (commands[0] == "Plunder")
                {
                    int tempPopulation = int.Parse(commands[2]);
                    int tempGold = int.Parse(commands[3]);

                    for (int i = 0; i < destinations.Count; i++)
                    {
                        if (destinations[i].city == tempCity)
                        {
                            destinations[i].population -= tempPopulation;
                            destinations[i].gold -= tempGold;
                            Console.WriteLine($"{tempCity} plundered! {tempGold} gold stolen, {tempPopulation} citizens killed.");

                            if (destinations[i].population <= 0 || destinations[i].gold <= 0)
                            {
                                Console.WriteLine($"{tempCity} has been wiped off the map!");
                                destinations.RemoveAt(i);
                            }
                            break;
                        }
                    }
                }
                else if (commands[0] == "Prosper")
                {
                    int tempGold = int.Parse(commands[2]);
                    if (tempGold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        input = Console.ReadLine();
                        continue;
                    }

                    for (int i = 0; i < destinations.Count; i++)
                    {
                        if (destinations[i].city == tempCity)
                        {
                            destinations[i].gold += tempGold;
                            Console.WriteLine($"{tempGold} gold added to the city treasury. {tempCity} now has {destinations[i].gold} gold.");
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Ahoy, Captain! There are {destinations.Count} wealthy settlements to go to:");
            List<Destination> final = destinations.OrderBy(order => order.gold).ToList();
            for (int i = destinations.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{final[i].city} -> Population: {final[i].population} citizens, Gold: {final[i].gold} kg");
            }
        }
    }

    class Destination
    {
        public string city { get; set; }
        public int population { get; set; }
        public int gold { get; set; }

        public Destination(string City, int Population, int Gold)
        {
            this.city = City;
            this.population = Population;
            this.gold = Gold;
        }
    }
}
