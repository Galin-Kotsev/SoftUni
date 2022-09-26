using System;

namespace _7._Сумиране_на_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                sum += x;
            }

            Console.WriteLine(sum);
        }
    }
}
