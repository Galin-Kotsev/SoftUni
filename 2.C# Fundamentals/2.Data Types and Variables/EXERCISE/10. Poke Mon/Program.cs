using System;

namespace _10._Poke_Mon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int pokes = 0;
            int exhoustn = n / 2;


            while (n >= m)
            {
                n -= m;
                pokes++;

                if (n == exhoustn && y > 0)
                {

                    n /= y;
                   
                }
            }

            

            Console.WriteLine(n);
            Console.WriteLine(pokes);
        }
    }
}
