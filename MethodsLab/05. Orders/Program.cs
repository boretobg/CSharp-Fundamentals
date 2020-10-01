using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            Price(type, quantity);
        }

        static void Price(string type, int quantity)
        {
            switch (type)
            {
                case "coffee":
                    Console.WriteLine($"{quantity * 1.5:f2}");
                    break;
                case "water":
                    Console.WriteLine($"{quantity * 1:f2}");
                    break;
                case "coke":
                    Console.WriteLine($"{quantity * 1.4:f2}");
                    break;
                case "snacks":
                    Console.WriteLine($"{quantity * 2:f2}");
                    break;
            }
        }
    }
}
