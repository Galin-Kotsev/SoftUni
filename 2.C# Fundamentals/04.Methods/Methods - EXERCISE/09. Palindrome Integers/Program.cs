using System;
using System.Linq;

namespace _09._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();

            PalindromCheck(numbers);
        }

        private static void PalindromCheck(string numbers)
        {
            while (numbers != "END")
            {
                bool palindrome = false;

                if (numbers == string.Join("", numbers.Reverse()))
                {
                    palindrome = true;
                }

                if (palindrome)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                numbers = Console.ReadLine();
            }
        }
    }
}
