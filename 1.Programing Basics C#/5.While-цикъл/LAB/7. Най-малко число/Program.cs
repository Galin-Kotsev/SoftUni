using System;

namespace _7._Най_малко_число
{
    class Program
    {
        static void Main(string[] args)
        {
            string n = Console.ReadLine();
            int min = int.MaxValue;

            while (n != "Stop")
            {

                int number = int.Parse(n);
                n = Console.ReadLine();
                if (min > number)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }
    }
}
