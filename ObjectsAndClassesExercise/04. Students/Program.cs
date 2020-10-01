using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                List<string> input = Console.ReadLine().Split().ToList();
                Student student = new Student();
                student.firstName = input[0];
                student.lastName = input[1];
                student.grade = float.Parse(input[2]);
                students.Add(student);
            }

            List<Student> sort = students.OrderBy(o => o.grade).ToList();

            for (int i = sort.Count - 1; i >= 0 ; i--)
            {
                Console.WriteLine($"{sort[i].firstName} {sort[i].lastName}: {sort[i].grade:f2}");
            }
        }
    }

    class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public float grade { get; set; }


        public Student()
        {

        }
        public Student(string FirstName, string LastName, float Grade)
        {
            this.firstName = FirstName;
            this.lastName = lastName;
            this.grade = Grade;
        }
    }

}
