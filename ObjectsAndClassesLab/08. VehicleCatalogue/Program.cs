using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace _08._VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            List<Truck> trucks = new List<Truck>();

            Catalog catalog = new Catalog();
            List<Catalog> catalogs = new List<Catalog>();

            bool hasCars = false;
            bool hasTrucks = false;

            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] line = input.Split("/").ToArray();

                if (line[0] == "Car")
                {
                    Car car = new Car(line[1], line[2], int.Parse(line[3]));
                    cars.Add(car);
                    catalog.Cars = cars;
                    hasCars = true; 
                }
                else
                {
                    Truck truck = new Truck(line[1], line[2], int.Parse(line[3]));
                    trucks.Add(truck);
                    catalog.Trucks = trucks;
                    hasTrucks = true;
                }
                input = Console.ReadLine();
            }

            if (hasCars)
            {
                Console.WriteLine("Cars:");
                foreach (Car car in cars)
                {
                    Console.WriteLine($"{car.brand}: {car.model}- {car.horsePower}hp");
                }
            }

            if (hasTrucks)
            {
                Console.WriteLine("Trucks:");
                foreach (Truck truck in trucks)
                {
                    Console.WriteLine($"{truck.brand}: {truck.model} - {truck.weight}kg");
                }
            }
            
            
        }
    }

    public class Car
    {
        public string brand;
        public string model;
        public int horsePower;

        public Car(string Brand, string Model, int HorsePower)
        {
            this.brand = Brand;
            this.model = Model;
            this.horsePower = HorsePower;
        }
    }

    public class Truck
    {
        public string brand;
        public string model;
        public int weight;

        public Truck(string Brand, string Model, int Weight)
        {
            this.brand = Brand;
            this.model = Model;
            this.weight = Weight;
        }
    }

    class Catalog
    {
        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }

    }
}
