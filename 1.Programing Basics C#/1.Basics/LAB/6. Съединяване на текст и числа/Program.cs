using System;

namespace _6._Съединяване_на_текст_и_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string city = Console.ReadLine();

            Console.WriteLine($"You are { firstName} { lastName}, a { age}-years old person from {city}.");

        }
    }
}
