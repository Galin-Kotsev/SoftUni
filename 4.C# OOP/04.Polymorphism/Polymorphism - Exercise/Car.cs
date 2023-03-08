using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public class Car : IVehicle
    {
        public Car(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity { get ; set ; }
        public double FuelConsumption { get; set; }

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
            FuelQuantity += amount;
        }
    }
}
