using System;

namespace _4._Задължителна_литература
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pages
            int pages = int.Parse(Console.ReadLine());
            // Pages per Hour
            int pph = int.Parse(Console.ReadLine());
            //Days
            int days = int.Parse(Console.ReadLine());

            int result = (pages / pph) / days;
            Console.WriteLine(result);

           
        }
    }
}
