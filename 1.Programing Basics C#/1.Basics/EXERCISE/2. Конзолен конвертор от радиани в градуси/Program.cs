using System;

namespace _2._Конзолен_конвертор_от_радиани_в_градуси
{
    class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degree = radians * 180 / Math.PI;
                Console.WriteLine(degree);
        }
    }
}
