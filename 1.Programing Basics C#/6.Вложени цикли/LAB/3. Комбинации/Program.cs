using System;

namespace _3._Комбинации
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int a = 0; a <= n ; a++)
            {
                for (int b = 0; b <= n; b++)
                {
                    for (int c = 0; c <= n; c++)
                    {

                        int x = a + b + c;

                        if (x == n)
                        {
                            counter++;
                        }
                    }
                }
            }
          
            Console.WriteLine(counter);
        }
    }
}
