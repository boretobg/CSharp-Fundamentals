using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Nikulden_sMeals
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Person>();
            string input = Console.ReadLine();
            int count = 0;
            while (input != "Stop")
            {
                var cmd = input.Split("-");

                if (cmd.Contains("Like"))
                {
                    bool nameExists = false;
                    bool likeExists = false;

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].name == cmd[1])
                        {
                            if (list[i].liked.Contains(cmd[2]))
                            {
                                likeExists = true;
                                break;
                            }
                            nameExists = true;
                            list[i].liked += cmd[2] + " ";
                        }
                    }
                    if (likeExists)
                    {
                        input = Console.ReadLine();
                        continue;
                    }

                    if (!nameExists)
                    {
                        Person temp = new Person();
                        temp.name = cmd[1];
                        temp.liked += cmd[2] + " ";
                        list.Add(temp);
                    }
                }
                else if (cmd.Contains("Unlike"))
                {
                    bool nameExists = false;
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i].name.Contains(cmd[1]))
                        {
                            nameExists = true;
                            if (list[i].liked.Contains(cmd[2]))
                            {
                                string toRemove = cmd[2];
                                int indexToRemove = list[i].liked.IndexOf(toRemove);
                                list[i].liked = list[i].liked.Remove(indexToRemove, toRemove.Length);
                                count++;
                                Console.WriteLine($"{cmd[1]} doesn't like the {cmd[2]}.");
                            }
                            else
                            {
                                Console.WriteLine($"{cmd[1]} doesn't have the {cmd[2]} in his/her collection.");
                            }
                        }
                    }

                    if (!nameExists)
                    {
                        Console.WriteLine($"{cmd[1]} is not at the party.");
                    }
                }

                input = Console.ReadLine();
            }

            List<Person> ordered = list.OrderByDescending(x => x.liked).ThenBy(x => x.name).ToList();
            for (int i = 0; i < ordered.Count; i++)
            {
                var meals = ordered[i].liked.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                Console.WriteLine($"{ordered[i].name}: {string.Join(", ", meals)}");
            }
            Console.WriteLine($"Unliked meals: {count}");
        }
    }

    public class Person
    {
        public string name { get; set; }
        public string liked { get; set; }
    }
}
