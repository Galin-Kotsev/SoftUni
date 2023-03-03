using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double width;
        private double length;

        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double Length
        { get => length; private set => length = value; }

        public double Width 
        { get => width; private set => width = value; }

        public override double CalculateArea()
        {
            return length * width;
        }

        public override double CalculatePerimeter()
        {
            return length + length + width + width;
        }

        public override string Draw()
        {
            return $"Drawing {this.GetType().Name}";
        }
    }
}
