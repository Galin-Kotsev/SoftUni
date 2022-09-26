using System;

namespace _3._Суми_прости_и_непрости_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int prime = 0;
            int nonPrime = 0;
            int num;




            while ( input != "stop")
            {
                num = int.Parse(input);
                

                if (num  < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                bool isPrime = true;

                for (int i = 2; i < num; i++)
                {
                    
                    if (num%i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    prime += num;
                }
                else
                {
                    nonPrime += num;
                }

                input = Console.ReadLine();

            }
            Console.WriteLine($"Sum of all prime numbers is: {prime}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrime}");
        }
    }
}
