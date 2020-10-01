using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;

namespace _05._Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Students> allStudents = new List<Students>();

            int count = 0;
            string tempFirst = string.Empty;
            string tempSecond = string.Empty; 
            string line = Console.ReadLine();
            while (line != "end")
            {
                string[] input = line.Split().ToArray();
                Students students = new Students(input[0], input[1], int.Parse(input[2]), input[3]);
                if (students.firstName == tempFirst && students.secondName == tempSecond)
                {
                    allStudents.RemoveAt(count - 1);
                    allStudents.Insert(count - 1, students);
                    line = Console.ReadLine();
                    continue;
                }
                tempFirst = input[0];
                tempSecond = input[1];
                allStudents.Add(students);
                count++;
                line = Console.ReadLine();
            }

            string townGoal = Console.ReadLine();

            foreach (Students students in allStudents)
            {
                if (students.town == townGoal)
                {
                    Console.WriteLine($"{students.firstName} {students.secondName} is {students.age} years old.");
                }
            }
        }
    }

    public class Students
    {
        public string firstName;
        public string secondName;
        public int age;
        public string town;

        public Students(string FirstName, string SecondName, int Age, string Town)
        {
            this.firstName = FirstName;
            this.secondName = SecondName;
            this.age = Age;
            this.town = Town;
        }

    }
}

