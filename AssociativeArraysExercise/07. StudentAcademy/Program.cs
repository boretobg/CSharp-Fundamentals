using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _07._StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Info> students = new List<Info>();

            for (int i = 0; i < n; i++)
            {
                bool alreadyIn = false;
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].name == name)
                    {
                        students[j].count++;
                        students[j].grade += grade;
                        alreadyIn = true;
                        break;
                    }
                }

                if (alreadyIn)
                {
                    continue;
                }

                Info current = new Info(name, grade, 1, 1);
                students.Add(current);
            }

            students.OrderByDescending(n => n);

            foreach (var item in students)
            {
                item.average = item.grade / item.count;
            }

            List<Info> sorted = students.OrderByDescending(o => o.average).ToList();

            foreach (var item in sorted)
            {
                if (item.average >= 4.5)
                {
                    Console.WriteLine($"{item.name} –> {item.average:f2}");
                }
            }
        }
    }

    class Info
    {
        public string name { get; set; }
        public double grade { get; set; }
        public double average { get; set; }
        public int count { get; set; }

        public Info()
        {

        }
        public Info(string Name, double Grade, double Average, int Count)
        {
            this.name = Name;
            this.grade = Grade;
            this.average = Average;
            this.count = Count;
        }
    }
}
