using System;

namespace _1._Числа_до_1000__завършващи_на_7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i%10==7)
                {
                    Console.WriteLine(i);
                }
                
            }
        }
    }
}
