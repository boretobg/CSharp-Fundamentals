using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playersNames = Console.ReadLine().Split(", ").ToArray();
            string regexName = @"[A-Za-z]";
            string regexNum = @"\d";
            var allPlayers = new List<Person>();

            string input = Console.ReadLine();
            while (input != "end of race")
            {
                var nameMatches = Regex.Matches(input, regexName);
                var numMatches = Regex.Matches(input, regexNum);

                string currentName = string.Join("", nameMatches);
                if (playersNames.Contains(currentName))
                {
                    bool alreadyIn = false;
                    for (int i = 0; i < allPlayers.Count; i++)
                    {
                        if (allPlayers[i].name == currentName)
                        {
                            foreach (Match item in numMatches)
                            {
                                allPlayers[i].number += int.Parse(item.Value);
                                alreadyIn = true;
                            }
                        }
                    } 
                    if (alreadyIn)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    int currentNum = 0;
                    foreach (Match item in numMatches)
                    {
                        currentNum += int.Parse(item.Value);
                    }
                    Person players = new Person(currentName, currentNum);
                    allPlayers.Add(players);
                }
                else
                {
                    input = Console.ReadLine();
                    continue;
                }
                
                input = Console.ReadLine();
            }

            List<Person> output = allPlayers.OrderByDescending(x => x.number).ToList();
            Console.WriteLine($"1st place: {output[0].name}");
            Console.WriteLine($"2nd place: {output[1].name}");
            Console.WriteLine($"3rd place: {output[2].name}");

        }
    }

    class Person
    {
        public string name { get; set; }
        public int number { get; set; }

        public Person(string Name, int Number)
        {
            this.name = Name;
            this.number = Number;
        }
    }
}
