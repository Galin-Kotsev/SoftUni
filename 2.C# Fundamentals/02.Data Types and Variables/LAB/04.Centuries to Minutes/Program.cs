using System;

namespace _04.Centuries_to_Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());


            int years = input * 100;
            
            int days = (int)(years * 365.2422);

            long hours = days * 24;
            long minutes = hours * 60;

            Console.WriteLine($"{input} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");


        }
    }
}
