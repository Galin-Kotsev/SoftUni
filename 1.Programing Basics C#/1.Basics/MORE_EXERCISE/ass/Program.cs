using System;

namespace ass
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();


            if (name == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else if (name != "sunny")
            {
                Console.WriteLine("It's cold outside!");
            }
           
            
        }
    }
}
