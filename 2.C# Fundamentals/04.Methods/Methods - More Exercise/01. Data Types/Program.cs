using System;

namespace _01._Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string input = Console.ReadLine();

            if (command == "int")
            {
                int number = int.Parse(input);
                int result = Print(number);
                Console.WriteLine(result);
            }
            else if (command == "real")
            {
                double number = double.Parse(input);
                double result = Print(number);
                Console.WriteLine($"{result:f2}");
            }
            else if (command == "string")
            {
                Console.WriteLine(Print(input));
            }
        }

        private static int Print(int input)
        {
            return input * 2;
        }

        private static double Print(double input)
        { 
            return input * 1.5 ;
        }

        private static string Print(string input)
        {
            return input = $"${input}$";
        }
    }

}