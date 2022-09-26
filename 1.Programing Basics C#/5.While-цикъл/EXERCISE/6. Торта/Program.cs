using System;

namespace _6._Торта
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int peaces = 0;
            
            string input = Console.ReadLine();

            peaces = w * h;

            while (input != "STOP")
            {
                int peace = int.Parse(input);

                peaces -= peace;

                if (peaces <= 0)
                {
                    Console.WriteLine($"No more cake left! You need {Math.Abs(peaces)} pieces more.");
                    return;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"{peaces} pieces are left.");
        }
    }
}
