using System;

namespace _10._Прогноза_за_времето___част_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());
            //"IF" is stupid but but it works, its not stupid.
            if (degree >= 35.00)
            {
                Console.WriteLine("unknown");
            }
             else if (degree >= 26.00)
            {
                Console.WriteLine("Hot");
            }
            else if (degree >= 20.10) 
            {
                Console.WriteLine("Warm");
            }
            else if (degree >= 15.00)
            {
                Console.WriteLine("Mild");
            }
            else if (degree >= 12)
            {
                Console.WriteLine("Cool");
            }
            else if (degree >= 5)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
