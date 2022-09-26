using System;

namespace _7._Лица_на_фигури
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();

            if (figure == "square")
            {
                double num1 = double.Parse(Console.ReadLine());
                double square = num1 * num1;
                Console.WriteLine($"{square:f3}");
            }
            else if (figure == "rectangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double rectangle = num1 * num2;
                Console.WriteLine($"{rectangle:f3}");
            }
            else if (figure == "circle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double circle = num1 * num1 * Math.PI;
                Console.WriteLine($"{circle:f3}");
            }
            else if (figure == "triangle")
            {
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double triangle = 0.5 * num1 * num2;
                Console.WriteLine($"{triangle:f3}");
            }
        }
    }
}
