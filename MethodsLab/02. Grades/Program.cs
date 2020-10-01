using System;

namespace _02._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            GradeCheck(grade);
        }

        static void GradeCheck(double grade)
        {
            if (grade >= 5.50)
            {
                Console.WriteLine("Excellent");
            }
            else if (grade >= 4.50)
            {
                Console.WriteLine("Verry good");
            }
            else if (grade >= 3.50)
            {
                Console.WriteLine("Good");
            }
            else if (grade >= 3.00)
            {
                Console.WriteLine("Poor");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
