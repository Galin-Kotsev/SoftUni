using System;

namespace _7._Преместване
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int volume = w * l * h;

            while (input != "Done")
            {
                int n = int.Parse(input);
                volume -= n;

                if (volume <= 0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(volume)} Cubic meters more.");
                    return;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"{volume} Cubic meters left.");
        }
    }
}
