using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    public class Program
    {
        static void Main(string[] args)
        {
            Catalog catalog = new Catalog();

            string input = Console.ReadLine();
            input = AddToColection(catalog, input);
            PrintCars(catalog);
            PrintTrucks(catalog);
        }

        private static void PrintTrucks(Catalog catalog)
        {
            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");

                foreach (var truck in catalog.Trucks.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
        }

        private static void PrintCars(Catalog catalog)
        {
            if (catalog.Cars.Any())
            {
                Console.WriteLine("Cars:");

                foreach (var car in catalog.Cars.OrderBy(x => x.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
        }

        private static string AddToColection(Catalog catalog, string input)
        {
            while (input != "end")
            {
                string[] info = input.Split("/");
                string type = info[0];
                string brand = info[1];
                string model = info[2];
                int otherInfo = int.Parse(info[3]);

                if (type == "Car")
                {
                    catalog.Cars.Add(new Car(brand, model, otherInfo));
                }
                else if (type == "Truck")
                {
                    catalog.Trucks.Add(new Truck(brand, model, otherInfo));
                }

                input = Console.ReadLine();
            }

            return input;
        }
    }
}

public class Car
{
    public Car(string brand, string model, int horsePower)
    {
        Brand = brand;
        Model = model;
        HorsePower = horsePower;
    }

    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }
}

public class Truck
{
    public Truck(string brand, string model, int weight)
    {
        Brand = brand;
        Model = model;
        Weight = weight;
    }
    
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }
}

public class Catalog
{
    public Catalog()
    {
        Cars = new List<Car>();
        Trucks = new List<Truck>();
    }
    public List<Car> Cars { get; set; }
    public List<Truck> Trucks { get; set; }
}