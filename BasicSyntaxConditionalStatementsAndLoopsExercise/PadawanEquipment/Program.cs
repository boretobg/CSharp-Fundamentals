using System;

namespace PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance = double.Parse(Console.ReadLine());
            double students = double.Parse(Console.ReadLine());
            double sabrePrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double sabre = (students + Math.Ceiling(students * 0.1)) * sabrePrice;
            double robe = students * robePrice;
            double belt = (students - ((int)students / 6)) * beltPrice;

            double price = sabre + robe + belt;

            if (price <= balance)
            {
                Console.WriteLine($"The money is enough - it would cost {price:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {Math.Abs(balance - price):f2}lv more.");
            }
        }
    }
}
