using System;

namespace _08._Math_Power___WITH_NO_MATH.POW_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());


            int result = b * a;

            for (int i = 2; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine(result);
        }
    }
}
