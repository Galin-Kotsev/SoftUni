using System;

namespace _01._Excursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int group = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());
            int cards = int.Parse(Console.ReadLine());
            int tickeds = int.Parse(Console.ReadLine());

            double nightsTotal = nights * 20;
            double transpordCards = cards * 1.60;
            double museumTickeds = tickeds * 6;

            double onePerson = nightsTotal + transpordCards + museumTickeds;
            double sumGroup = onePerson * group;
            double unexpected = sumGroup + (sumGroup * 0.25);
            Console.WriteLine($"{unexpected:f2}");



           
        }
    }
}
