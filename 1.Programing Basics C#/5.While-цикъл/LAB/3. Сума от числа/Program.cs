using System;

namespace _3._Сума_от_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;

            while (sum < n)
            {
                int added = int.Parse(Console.ReadLine());
                sum = sum+added;

            }

            Console.WriteLine(sum);
        } 
    }
}
