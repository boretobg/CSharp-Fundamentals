using System;

namespace _01.__SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsPerHour = 0;
            for (int i = 0; i < 3; i++)
            {
                studentsPerHour += int.Parse(Console.ReadLine());
            }

            int studentsCount = int.Parse(Console.ReadLine());
            int count = 0;

            while (studentsCount > 0)
            {
                count++;
                if (count % 4 == 0)
                {
                    continue;
                }

                studentsCount -= studentsPerHour;
            }

            Console.WriteLine($"Time needed: {count}h.");
        }
    }
}
