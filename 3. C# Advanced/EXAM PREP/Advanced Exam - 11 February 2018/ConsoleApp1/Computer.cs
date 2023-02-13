using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
		private string model;
		private int capacity;
		private List<CPU> multiprocessor;

        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
			Multiprocessor = new List<CPU>(capacity);
        }

        public List<CPU> Multiprocessor
        {
			get { return multiprocessor; }
			set { multiprocessor = value; }
		}
		public int Capacity
		{
			get { return capacity; }
			set { capacity = value; }
		}
		public string Model
		{
			get { return model; }
			set { model = value; }
		}

        public int Count 
		{ 
			get
			{
				return multiprocessor.Count;
			}
		}

        public void Add(CPU cpu) 
		{
			if (multiprocessor.Count < capacity)
			{
				multiprocessor.Add(cpu);
			}
		}
		public bool Remove(string brand) 
		{
			CPU cpu 
				= multiprocessor.FirstOrDefault(x => x.Brand == brand);

			if (cpu != null)
			{
				multiprocessor.Remove(cpu);
				return true;
			}
			else
			{
                return false;
            }
		}
		public CPU MostPowerful() 
		{
			return multiprocessor.OrderByDescending(x => x.Frequency).First();
        }

        public CPU GetCPU(string brand)
        {
			CPU cpu = multiprocessor.FirstOrDefault(x => x.Brand == brand);

			if(cpu != null)
			{
				return cpu; 
			}
			else
			{
				return null;
			}
			
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
			sb.AppendLine($"CPUs in the Computer {model}:");

			foreach (CPU cpu in multiprocessor) 
			{
                sb.AppendLine(cpu.ToString());
			}

            return sb.ToString().Trim();
        }
    }
}
