﻿using System.Text;

namespace ComputerArchitecture
{
    public class CPU
    {
        private string brand;
        private int cores;
        private double frequency;

        public CPU(string brand, int cores, double frequency)
        {
            Brand = brand;
            Cores = cores;
            Frequency = frequency;
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double Frequency
        {
            get { return frequency; }
            set { frequency = value; }
        }
        public int Cores
        {
            get { return cores; }
            set { cores = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{brand} CPU:");
            sb.AppendLine($"Cores: {cores}");
            sb.AppendLine($"Frequency: {frequency:f1} GHz");
            return sb.ToString().Trim();
        }
    }
}