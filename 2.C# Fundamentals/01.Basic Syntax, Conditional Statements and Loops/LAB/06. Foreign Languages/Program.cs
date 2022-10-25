namespace _06._Foreign_Languages
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();

            if (country == "Spain" || country == "Mexico" || country == "Argentina")
            {
                Console.WriteLine("Spanish");
            }
            else if (country == "England" || country == "USA")
            {
                Console.WriteLine("English");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
