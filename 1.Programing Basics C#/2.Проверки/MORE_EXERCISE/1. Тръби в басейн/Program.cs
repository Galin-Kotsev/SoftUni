using System;

namespace _1._Тръби_в_басейн
{
    class Program
    {
        static void Main(string[] args)
        {
            //inputs
            int v = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());


            double pipeLine1 = p1 * h; //300l
            double pipeLine2 = p2 * h;
            double totalLiters = (pipeLine1 + pipeLine2);
            double Line1Percent = pipeLine1 * 100 / totalLiters;// litres total
            double Line2Percent = pipeLine2 * 100 / totalLiters; ;
            double totalPercent = (pipeLine1 + pipeLine2) * 100 / v;
            
            

           if (totalLiters <= v)
           { 

                Console.WriteLine($"The pool is {totalPercent:f2}% full.Pipe 1: {Line1Percent:f2}%.Pipe 2: {Line2Percent:f2}%.");
           }
            else
           {
                Console.WriteLine($"For {h} hours the pool overflows with {totalLiters-v} liters.");
          }
           
            

        }
    }
}
