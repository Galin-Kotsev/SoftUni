using System;

namespace _5._Число_от_100_до_200
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = int.Parse(Console.ReadLine());

            if (x < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (x >= 100 && x <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else if (x > 200)
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
