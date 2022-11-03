using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _06._Vehicle_Catalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Catalogue carInfo = new Catalogue();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] VehicleInfo = input.Split(" ");

                string type = VehicleInfo[0];
                string model = VehicleInfo[1];
                string color = VehicleInfo[2];
                int horsePower = int.Parse(VehicleInfo[3]);

                if (type == "car")
                {
                    Car car = new Car(model, color, horsePower);
                    carInfo.Cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck(model, color, horsePower);
                    carInfo.Trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            string input2 = Console.ReadLine();

            while (input2 != "Close the Catalogue")
            {
                if (carInfo.Cars.Any(x => x.Model  == input2))
                {
                    Car car = carInfo.Cars.First(x => x.Model == input2);
                    Console.WriteLine("Type: Car");
                    Console.WriteLine($"Model: {car.Model}");
                    Console.WriteLine($"Color: {car.Color}");
                    Console.WriteLine($"Horsepower: {car.Horsepower}");
                }

                if (carInfo.Trucks.Any(x => x.Model == input2))
                {
                    Truck truck = carInfo.Trucks.First(x => x.Model == input2);
                    Console.WriteLine("Type: Truck");
                    Console.WriteLine($"Model: {truck.Model}");
                    Console.WriteLine($"Color: {truck.Color}");
                    Console.WriteLine($"Horsepower: {truck.Horsepower}");
                }


                input2 = Console.ReadLine();
            }

            if (carInfo.Cars.Count > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carInfo.Cars.Average(x => x.Horsepower):f2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: 0.00.");
            }

            if (carInfo.Trucks.Count > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {carInfo.Trucks.Average(x => x.Horsepower):f2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: 0.00.");
            }
        }
    }
}
public class Catalogue
{
    public Catalogue()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }

    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }
}
public class Car
{
    public Car(string model, string color, int horsePower)
    {
        Model = model;
        Color = color;
        Horsepower = horsePower;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
}
public class Truck
{
    public Truck(string model, string color, int horsepower)
    {
        Model = model;
        Color = color;
        Horsepower = horsepower;
    }

    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }
}
