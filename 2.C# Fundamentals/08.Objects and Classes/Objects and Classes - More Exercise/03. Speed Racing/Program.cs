using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace _03._Speed_Racing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string input;

            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string model = inputs[0];
                double fuel = double.Parse(inputs[1]);
                double consumption = double.Parse(inputs[2]);
                double distance = 0;

                var car = new Car(model, fuel, consumption, distance);

                cars.Add(car);
            }

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split(" ");

                string command = inputs[0];
                string model = inputs[1];
                double km = double.Parse(inputs[2]);

                if (command == "Drive")
                {
                    Car car = cars.FirstOrDefault(x => x.Model == model);

                    bool canMove = car.CanMove(km);

                    if (canMove)
                    {
                        car.Fuel -= km * car.Consumption;
                        car.Distance += km;
                    }
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
public class Car
{
    public Car(string model, double fuel, double consumption, double distance)
    {
        Model = model;
        Fuel = fuel;
        Consumption = consumption;
        Distance = distance;
    }

    public string Model { get; set; }
    public double Fuel { get; set; }
    public double Consumption { get; set; }
    public double Distance { get; set; }

    public bool CanMove(double km)
    {
        if (km * Consumption < Fuel)
        {
            return true;
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
            return false;
        }
    }

    public override string ToString() => $"{Model} {Fuel:f2} {Distance}";

}
