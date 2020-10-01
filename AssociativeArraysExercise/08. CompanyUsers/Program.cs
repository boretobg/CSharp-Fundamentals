using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08._CompanyUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Company> users = new List<Company>();

            string input = Console.ReadLine();
            while (input != "End")
            {
                bool alreadyIn = false;
                string[] command = input.Split(" -> ").ToArray();

                for (int i = 0; i < users.Count; i++)
                {
                    if (users[i].name == command[0])
                    {
                        if (!users[i].number.Contains(command[1]))
                        {
                            alreadyIn = true;
                            users[i].number += " " + command[1];
                            break;
                        }
                        else
                        {
                            alreadyIn = true;
                            break;
                        }
                    }
                }

                if (alreadyIn)
                {
                    input = Console.ReadLine();
                    continue;
                }

                Company temp = new Company(command[0], command[1]);
                users.Add(temp);
                input = Console.ReadLine();
            }

            List<Company> sorted = users.OrderBy(o => o.name).ToList();

            for (int i = 0; i < sorted.Count; i++)
            {
                Console.WriteLine(sorted[i].name);
                string[] outputs = sorted[i].number.Split().ToArray();
                for (int j = 0; j < outputs.Length; j++)
                {
                    Console.WriteLine($"-- {outputs[j]}");
                }
            }
        }
    }

    class Company
    {
        public string name { get; set; }
        public string number { get; set; }

        public Company(string Name, string Number)
        {
            this.name = Name;
            this.number = Number;
        }
    }
}
