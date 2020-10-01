using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._HeroRecruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> heroes = new List<string>();
            string line = Console.ReadLine();
            while (line != "End")
            {
                var input = line.Split();
                if (input.Contains("Enroll"))
                {
                    if (heroes.Contains(input[1]))
                    {
                        Console.WriteLine($"{input[1]} is already enrolled");
                    }
                    else
                    {
                        heroes.Add(input[1]);
                    }
                }
                else if (input.Contains("Learn")) //Learn {HeroName} {SpellName}":
                {
                    
                }
                else if (input.Contains("Unlearn"))
                {

                }
            }
        }
    }

    class Heroes
    {
        public string name { get; set; }
        public string spell { get; set; }

        public Heroes(string Name, string Spell)
        {
            this.name = Name;
            this.spell = Spell;
        }
    }
}
