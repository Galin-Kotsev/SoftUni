using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class Truck : IVehicle
    {
        public Truck(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double km)
        {
            if (FuelQuantity >= (FuelConsumption + 1.6) * km)
            {
                FuelQuantity -= (FuelConsumption + 1.6) * km;

                Console.WriteLine($"Truck travelled {km} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public void Refuel(double amount)
        {
            FuelQuantity += amount * 0.95;
        }
    }
}
