using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Course
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Course> courses = new List<Course>();
            Dictionary<string, string> names = new Dictionary<string, string>();

            string input = Console.ReadLine();
            while (input != "end")
            {
                bool repeated = false;
                string[] courseInfo = input.Split(" : ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                string[] tempName = courseInfo[1].Split().ToArray();
                names.Add(tempName[0], tempName[1]);

                for (int i = 0; i < courses.Count; i++)
                {
                    if (courses[i].title == courseInfo[0])
                    {
                        courses[i].name.Add(tempName[0], tempName[1]);
                        repeated = true;
                        input = Console.ReadLine();
                        break;
                    }
                }

                if (repeated)
                {
                    continue;
                }

                Course current = new Course(courseInfo[0], names);
                courses.Add(current);

                input = Console.ReadLine();
            }

            for (int i = 0; i < courses.Count; i++)
            {
                //Console.WriteLine($"{courses[i].title}: {courses[i].name.Count / 2}");
                //for (int j = 0; j < courses[i].name.Count; j++)
                //{
                //    Console.WriteLine($"-- {courses[i].name[j]} {courses[i].name[j + 1]}");
                //    j++;
                //}
            }

        }
    }

    class Course
    {
        public string title { get; set; }
        public Dictionary<string, string> name { get; set; }

        public Course(string Title, Dictionary<string, string> Name)
        {
            this.title = Title;
            this.name = Name;
        }
    }
}
