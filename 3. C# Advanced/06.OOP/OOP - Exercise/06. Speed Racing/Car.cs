﻿namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public Car
            (string model,
            double fuelAmount,
            double fuelConsumptionPerKilometer)
           
        {
            Model = model;
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            TravelledDistance = 0.0;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public double FuelAmount 
        {
            get { return fuelAmount; } 
            set { fuelAmount= value; }
        }
        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }
        public double TravelledDistance
        {
            get { return travelledDistance; }
            set { travelledDistance = value; }
        }

        public void Drive(double kms)
        {
            if (FuelAmount - (kms * FuelConsumptionPerKilometer) >= 0)
            {
                FuelAmount -= (kms * fuelConsumptionPerKilometer);

                TravelledDistance += kms;
            }
            else
            {
                Console.WriteLine($"Insufficient fuel for the drive");
            }
        }
    }
}
