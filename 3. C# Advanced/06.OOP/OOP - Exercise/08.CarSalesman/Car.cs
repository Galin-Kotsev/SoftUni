using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    public class Car
    {
        private string model;
        private int weight;
        private string color;
        private Engine engine;

        public Car(string model, int weight, string color, Engine engine, string model, int weight, string color, Engine engine)
        {
            Model = model;
            Weight = weight;
            Color = color;
            Engine = engine;
            Model = model;
            Weight = weight;
            Color = color;
            Engine = engine;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        public Engine Engine
        {
            get { return engine; }
            set { engine = value; }
        }

    }
}
