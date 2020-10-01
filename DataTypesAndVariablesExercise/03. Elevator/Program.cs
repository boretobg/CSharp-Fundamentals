using System;

namespace _03._Elevator
{
    class Program
    {
        static void Main(string[] args)
        { 
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            if (people % capacity == 0)
            {
                Console.WriteLine(people / capacity);
            }
            else
            {
                Console.WriteLine(people / capacity + 1);
            }
        }
    }
}
