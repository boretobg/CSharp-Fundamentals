using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._VehicleCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            double hpCarCount = 0;
            double hpCarSum = 0;
            double hpTruckCount = 0;
            double hpTruckSum = 0;

            string input = Console.ReadLine();
            while (input != "End")
            {
                string[] line = input.Split().ToArray();
                Vehicle vehicle = new Vehicle(line[0], line[1], line[2], int.Parse(line[3]));
                if (line[0] == "car")
                {
                    vehicle.type = "Car";
                    hpCarCount++;
                    hpCarSum += int.Parse(line[3]);
                }
                else
                {
                    vehicle.type = "Truck";
                    hpTruckCount++;
                    hpTruckSum += int.Parse(line[3]);
                }
                vehicles.Add(vehicle);
                input = Console.ReadLine();
            }

            input = Console.ReadLine();
            while (input != "Close the Catalogue")
            {
                for (int i = 0; i < vehicles.Count; i++)
                {
                    if (input == vehicles[i].model)
                    {
                        Console.WriteLine($"Type: {vehicles[i].type}");
                        Console.WriteLine($"Model: {vehicles[i].model}");
                        Console.WriteLine($"Color: {vehicles[i].color}");
                        Console.WriteLine($"Horsepower: {vehicles[i].horsePower}");
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Cars have average horsepower of: {hpCarSum / hpCarCount:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {hpTruckSum / hpTruckCount:f2}.");
        }
    }

    class Vehicle
    {
        public string type { get; set; }
        public string model { get; set; }
        public string color { get; set; }
        public int horsePower { get; set; }

        public Vehicle(string Type, string Model, string Color, int HorsePower)
        {
            this.type = Type;
            this.model = Model;
            this.color = Color;
            this.horsePower = HorsePower;
        }
    }
}
