using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismExercise
{
    public interface IVehicle 
    {
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public double Capacity { get; set; }

        public void Drive(double km);
        public void Refuel(double amount);
    }
}
