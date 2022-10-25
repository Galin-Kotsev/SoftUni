using System;

namespace _11.Refactor_Volume_of_Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double heigth = double.Parse(Console.ReadLine());

            double V = 0;
            V = (lenght * width * heigth) / 3;

            Console.Write($"Length: ");
            Console.Write($"Width: ");
            Console.Write($"Height: ");


            Console.Write($"Pyramid Volume: {V:f2}");

        }
    }
}
