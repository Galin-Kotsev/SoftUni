﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Raw_Data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            string input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string model = inputs[0];
                int engineSpeed = int.Parse(inputs[1]);
                int enginePower = int.Parse(inputs[2]);
                int cargoWeigth = int.Parse(inputs[3]);
                string cargoType = inputs[4];

                Car car 
                    = new Car(model,new Cargo(cargoWeigth,cargoType),new Engine(engineSpeed,enginePower));

                cars.Add(car);
            }

            input = Console.ReadLine();

            foreach (var car in cars)
            {
                if (input == "fragile")
                {
                    if (car.Cargo.CargoType == "fragile" && car.Cargo.CargoWeight < 1000)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
                else if (input == "flamable")
                {
                    if (car.Cargo.CargoType == "flamable" && car.Engine.EnginePower > 250)
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
public class Car
{
    public Car(string model, Cargo cargo, Engine engine)
    {
        Model = model;
        Cargo = cargo;
        Engine = engine;
    }
    public string Model { get; set; }
    public Cargo Cargo { get; set; }
    public Engine Engine { get; set; }
}
public class Cargo
{
    public Cargo(int cargoWeight, string cargoType)
    {
        CargoWeight = cargoWeight;
        CargoType = cargoType;
    }
    public int CargoWeight { get; set; }
    public string CargoType { get; set; }
}

public class Engine
{
    public Engine(int engineSpeed, int enginePower)
    {
        EngineSpeed = engineSpeed;
        EnginePower = enginePower;
    }
    public int EngineSpeed { get; set; }
    public int EnginePower { get; set; }

}
