using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftUniKindergarten
{
    public class Kindergarten
    {
        private string name;
        private int capacity;
        private List<Child> registry;

        public Kindergarten(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Registry = new List<Child>();
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }
        public List<Child> Registry
        {
            get { return registry; }
            set { registry = value; }
        }

        public int ChildrenCount
        {
            get
            {
                return registry.Count;
            }
        }
        public bool AddChild(Child childOne)
        {
            if (registry.Count < capacity)
            {
                registry.Add(childOne);
                return true;
            }

            return false;
        }

        public bool RemoveChild(string y)
        {
            Child child
                = registry.FirstOrDefault(x => x.FirstName + " " + x.LastName == y);

            if (child != null)
            {
                registry.Remove(child);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string RegistryReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Registered children in {Name}:");

            foreach (Child child in registry.OrderByDescending(x => x.Age).ThenBy(x => x.LastName).ThenBy(x => x.FirstName)) 
            {
                sb.AppendLine(child.ToString());
            }
            return sb.ToString().Trim();
        }

        public Child GetChild(string y)
        {
            Child child
                 = registry.FirstOrDefault(x => x.FirstName + " " + x.LastName == y);

            if (child != null)
            {
                return child;
            }
            else
            {
                return null;
            }
        }
    }
}
