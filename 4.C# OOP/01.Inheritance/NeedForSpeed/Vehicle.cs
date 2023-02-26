using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private double fuelConsumption;
        private double fuel;
        private int horsePower;

        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
            FuelConsumption = 1.25;
        }

        public virtual double FuelConsumption
        {
            get
            { return fuelConsumption; }
            set
            { fuelConsumption = value; }
        }
        public double Fuel
        {
            get
            { return fuel; }
            set
            { fuel = value; }
        }
        public int HorsePower
        {
            get
            { return horsePower; }
            set
            { horsePower = value; }
        }

        public virtual void Drive(double kilometers)
        {
            Fuel -= kilometers * FuelConsumption;
        }
    }
}
