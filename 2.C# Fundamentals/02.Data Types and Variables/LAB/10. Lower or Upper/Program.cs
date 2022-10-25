using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {

            string a = Console.ReadLine();

            if (a == a.ToUpper())
            {
                Console.WriteLine($"upper-case");
            }
            else
            {
                Console.WriteLine($"lower-case");
            }
        }
    }
}
