using System;

namespace _01._CounterStrike
{
    class Program
    {
        static void Main(string[] args)
        {
            short energy = short.Parse(Console.ReadLine());
            string input = String.Empty;
            short distance = 0;
            short count = 0;

            Calculation(energy, input, distance, count);
        }

        static void Calculation(short energy, string input,short distance, short count)
        {
            while (true)
            {
                input = Console.ReadLine();
                if (input == "End of battle")
                {
                    Console.WriteLine($"Won battles: {count}. Energy left: {energy}");
                    break;
                }
                distance = short.Parse(input);
                if (distance > energy)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {count} won battles and {energy} energy");
                    break;
                }
                energy -= distance;
                count++;
                if (count % 3 == 0)
                {
                    energy += count;
                }

            }
        }
    }
}
