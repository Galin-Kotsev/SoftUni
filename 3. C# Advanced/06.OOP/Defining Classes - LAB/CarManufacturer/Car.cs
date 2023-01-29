using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        private Engine engine;
        private Tire[] tire;

        public Car()
        {
            Make = "VW";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year)
            :this()
        {
            Make = make;
            Model = model;
            Year = year;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            :this()
        {
            Make= make;
            Model= model;
            Year= year;
            FuelQuantity= fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine, Tire[] tires)
            : this(make, model, year, fuelQuantity, fuelConsumption)
        {
            Engine= engine;
            Tires = tires; 
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tires { get; set; }    
        

        public void Drive(double distance)
        {
            if(FuelQuantity - distance * FuelConsumption >= 0)
            {
                FuelQuantity -= distance * FuelConsumption;
            }
            else
            {
                Console.WriteLine($"Not enough fuel to perform this trip!");
            }

        }

        public string WhoAmI()
        {   //return $"Make: {Make}\r\n Model: {Model}\r\n Year: {Year}\r\n Fuel: {FuelQuantity:F2}\r\n";
            StringBuilder stringBuilder= new StringBuilder();
            stringBuilder.AppendLine($"Make: {Make}");
            stringBuilder.AppendLine($"Model: {Model}");
            stringBuilder.AppendLine($"Year: {Year}");
            stringBuilder.AppendLine($"Fuel: {FuelQuantity:F2}");

            return stringBuilder.ToString();
        }

    }
}
