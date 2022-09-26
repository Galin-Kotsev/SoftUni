using System;

namespace _11._Multiplication_Table_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if ( b <= 10 )
            {
                for (int i = b; i <= 10; i++)
                {
                    Console.WriteLine($"{a} X {i} = {a * i}");
                }
            }
            else if (b > 10)
            {
                Console.WriteLine($"{a} X {b} = {a*b}");
            }
        }
    }
}
