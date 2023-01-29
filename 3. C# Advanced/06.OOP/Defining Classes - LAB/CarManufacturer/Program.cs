﻿using CarManufacturer;

public class StartUp
{
    public static void Main()
    {
        Car car = new Car();
        var tires 
            = new Tire[4]
        {
            new Tire(1, 2.5),
            new Tire(1, 2.1),
            new Tire(2, 0.5),
            new Tire(2, 2.3)
        };

        var engine 
            = new Engine(560, 6300);

        var lamborgghini 
            = new Car("Lamborghini", "Urus", 2010, 250, 9, engine, tires);


        car.Make = "VW";
        car.Model = "MK3";
        car.Year = 1992;
        car.FuelQuantity = 200;
        car.FuelConsumption = 200;

        car.Drive(2000);
        Console.WriteLine(car.WhoAmI());
        //Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
    }
}