using System;

namespace _01._BonusScoringSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int lectureCount = int.Parse(Console.ReadLine());
            int initialBonus = int.Parse(Console.ReadLine());

            double max = 0;
            double maxAttendance = 0;  

            for (int i = 0; i < studentsCount; i++)
            {
                int studentAttendances = int.Parse(Console.ReadLine());
                double totalBonus = studentAttendances * 1.0 / lectureCount * ( 5 + initialBonus);

                if (totalBonus > max)
                {
                    max = totalBonus;
                }
                if (studentAttendances > maxAttendance)
                {
                    maxAttendance = studentAttendances;
                }
            }

            Console.WriteLine($"Max Bonus: {Math.Ceiling(max)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
