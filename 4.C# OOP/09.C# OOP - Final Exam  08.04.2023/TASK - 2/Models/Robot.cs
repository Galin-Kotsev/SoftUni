using RobotService.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private int batteryLevel;
        private List<int> interfaceStandards;

        public Robot(string model, int batteryCapacity, int conversionCapacityIndex)
        {
            this.Model = model;
            this.BatteryCapacity = batteryCapacity;
            this.ConvertionCapacityIndex = conversionCapacityIndex;
            batteryLevel = batteryCapacity;
            this.interfaceStandards = new List<int>();

        }

        public string Model
        {
            get { return model; }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException
                    ("Model cannot be null or empty.");
                }

                model = value;
            }
        }

        public int BatteryCapacity
        {
            get { return batteryCapacity; }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException
                    ("Battery capacity cannot drop below zero.");
                }

                batteryCapacity = value;
            }
        }

        public int BatteryLevel
        {
            get { return batteryLevel; }

            private set
            {
                batteryLevel = value;
            }
        }

        public int ConvertionCapacityIndex { get; set; }

        public IReadOnlyCollection<int> InterfaceStandards { get; set; }

        public void Eating(int minutes)
        {
            batteryLevel += minutes;

            if (batteryLevel > batteryCapacity)
            {
                batteryLevel = batteryCapacity;
            }
        }

        public bool ExecuteService(int consumedEnergy)
        {
            
            if(batteryLevel >= consumedEnergy)
            {
                batteryLevel -= consumedEnergy;
                return true;
            }
            else
            {
                return false;
            }

        }

        public void InstallSupplement(ISupplement supplement)
        {
            interfaceStandards.Add(supplement.InterfaceStandard);
            batteryCapacity -= supplement.BatteryUsage;
            batteryLevel -= supplement.BatteryUsage;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{this.GetType().Name} {model}");
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");
            if (interfaceStandards.Any())
            {
                sb.AppendLine($"--Supplements installed: {string.Join(" ", interfaceStandards)}");
            }
            else
            {
                sb.AppendLine($"--Supplements installed: none");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
