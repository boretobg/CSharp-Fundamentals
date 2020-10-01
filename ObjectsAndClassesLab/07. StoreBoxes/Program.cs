using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._StoreBoxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> box = new List<Box>();

            string input = Console.ReadLine();
            while (input == "end")
            {
                string[] command = input.Split().ToArray();

                Box theBox = new Box();
                theBox.ItemQuantity = int.Parse(command[0]);
                theBox.Item.
            }
        }
    }

    public class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Box
    {
        public Box ()
        {
            Item = new Item();
        }

        public int Serial { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice { get; set; }

        public Box(int serial, Item item, int itemQuantity, double boxPrice)
        {
            this.Serial = serial;
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.BoxPrice = boxPrice;
        }
    }
}
