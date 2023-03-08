using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class Car : IVehicle
    {
        public Car(double fuelQuantity, double fuelConsumption, double capacity)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
            Capacity = capacity;

            if (fuelQuantity > capacity)
            {
                FuelQuantity = 0;
            }
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double Capacity { get; set; }

        public void Drive(double km)
        {
            if (FuelQuantity >= (FuelConsumption + 0.9) * km)
            {
                FuelQuantity -= (FuelConsumption + 0.9) * km;

                Console.WriteLine($"Car travelled {km} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public void Refuel(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
            }
            else 
            {
                if (FuelQuantity + amount > Capacity)
                {
                    Console.WriteLine($"Cannot fit {amount} fuel in the tank");
                }
                else
                {
                    FuelQuantity += amount;
                }
            }
        }
    }
}
