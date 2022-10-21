using System;
using System.IO;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int stamina = int.Parse(Console.ReadLine());
            
            int battle = 0;
            int count = 0;

            string input = Console.ReadLine();

            while (input != "End of battle")
            {
                int energy = int.Parse(input);

                if (stamina - energy < 0)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {battle} won battles and {stamina} energy");
                    return;
                }

                battle++;
                count++;

                stamina -= energy;

                if (count == 3)
                {
                    stamina += battle;
                    count = 0;
                }

                input = Console.ReadLine();
            }
                Console.WriteLine($"Won battles: {battle}. Energy left: {stamina}");
        }
    }
}
