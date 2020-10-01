using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._LegendaryFarming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            Items item = new Items();

            List<string> items = new List<string>();

            for (int i = input.Length - 1; i >= 0 ; i--)
            {
                item.name = input[i];
                item.quantity = int.Parse(input[i - 1]);
                items.Add(item.ToString());
            }
        }
    }

    class Items
    {
        public int quantity { get; set; }
        public string name { get; set; }

        public Items ()
        {

        }

        public Items (int Quantity, string Name)
        {
            this.quantity = Quantity;
            this.name = Name;
        }
    }
}
