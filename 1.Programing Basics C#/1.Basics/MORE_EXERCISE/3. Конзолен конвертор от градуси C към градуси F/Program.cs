using System;

namespace _3._Конзолен_конвертор_от_градуси_C_към_градуси_F
{
    class Program
    {
        static void Main(string[] args)
        {
            double degrees = double.Parse(Console.ReadLine());

            //F = C x (9/5) + 32 ( OPRAVETE TOQ C# )
            double faren = degrees * (9.0 / 5.0) + 32;
            Console.WriteLine($" {faren:f2}");
        }
    }
}
