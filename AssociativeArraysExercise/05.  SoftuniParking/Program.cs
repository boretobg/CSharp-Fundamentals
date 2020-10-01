using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.__SoftuniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Info> registrations = new List<Info>();

            for (int i = 0; i < n; i++)
            {
                bool alreadyRegistered = false;
                bool missing = true;
                string[] input = Console.ReadLine().Split().ToArray();
                string command = input[0];
                if (command == "unregister")
                {
                    for (int j = 0; j < registrations.Count; j++)
                    {
                        if (registrations[j].name == input[1])
                        {
                            registrations.RemoveAt(j);
                            Console.WriteLine($"{input[1]} unregistered successfully");
                            missing = false;
                            break;
                        }
                    }
                    if (missing)
                    {
                        Console.WriteLine($"ERROR: user {input[1]} not found");
                    }
                }
                else if (command == "register")
                {
                    for (int k = 0; k < registrations.Count; k++)
                    {
                        if (registrations[k].name == input[1])
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {registrations[k].plateNumber}");
                            alreadyRegistered = true;
                            break;
                        }
                    }

                    if (alreadyRegistered)
                    {
                        continue;
                    }

                    Info info = new Info(input[1], input[2]);
                    registrations.Add(info);
                    Console.WriteLine($"{input[1]} registered {input[2]} successfully");
                }
            }

            for (int i = 0; i < registrations.Count; i++)
            {
                Console.WriteLine($"{registrations[i].name} => {registrations[i].plateNumber}");
            }
        }
    }

    class Info
    {
        public string name { get; set; }
        public string plateNumber { get; set; }

        public Info(string Name, string PlateNumber)
        {
            this.name = Name;
            this.plateNumber = PlateNumber;
        }
    }
}
