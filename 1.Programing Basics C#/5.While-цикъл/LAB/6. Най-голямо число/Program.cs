using System;

namespace _6._Най_голямо_число
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int max = int.MinValue;

            while (n != "Stop")
            {

                int number = int.Parse(n);
                n = Console.ReadLine();
                if (max < number)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }
    }
}
