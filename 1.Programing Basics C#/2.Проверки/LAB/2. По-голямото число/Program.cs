using System;

namespace _2._По_голямото_число
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            if (x >= y)
            {
                Console.WriteLine(x);
            }
            else if (x <= y)
            {
                Console.WriteLine(y);
            }
        }
    }
}
