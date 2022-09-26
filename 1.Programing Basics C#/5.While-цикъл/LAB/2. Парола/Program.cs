using System;

namespace _2._Парола
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string password = Console.ReadLine();

            string addPass = Console.ReadLine();

            while (addPass != password)
            {
                addPass = Console.ReadLine();
            }

            Console.WriteLine($"Welcome {user}!");
        }
    }
}
