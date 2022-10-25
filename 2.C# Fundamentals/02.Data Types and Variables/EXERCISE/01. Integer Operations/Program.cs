using System;

namespace _01._Integer_Operations
{
    class Program
    {
        static void Main(string[] args)
        {

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            NewMethod(n1, n2, n3, n4);
        }

        private static void NewMethod(int n1, int n2, int n3, int n4)
        {
            int task1 = n1 + n2;
            int task2 = task1 / n3;
            int task3 = task2 * n4;

            Console.WriteLine(task3);
        }
    }
}
