using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> person = new List<Person>();
            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] line = input.Split().ToArray();
                Person people = new Person(line[0], int.Parse(line[1]), int.Parse(line[2]));
                person.Add(people);
                input = Console.ReadLine();
            }

            person.OrderBy(n => n.age);

            for (int i = person.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"{person[i].name} with ID: {person[i].id} is {person[i].age} years old.");
            }
        }
    }

    class Person
    {
        public string name { get; set; }
        public int id { get; set; }
        public int age { get; set; }

        public Person(string Name, int Id, int Age)
        {
            this.name = Name;
            this.id = Id;
            this.age = Age;
        }
    }
}
