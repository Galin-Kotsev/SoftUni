using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int input = int.Parse(Console.ReadLine());



            for (int i = 0; i < input; i++)
            {
                bool devisible = Devisible(i);
                bool oddDigit = OddDigit(i);

                if (devisible && oddDigit)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool OddDigit(int i)
        {
            string digit = i.ToString();

            int sum = 0;


            for (int j = 0; j < digit.Length; j++)
            {
                sum += int.Parse(digit[j].ToString());
            }

            if (sum % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        private static bool Devisible(int i)
        {
            string digit = i.ToString();


            for (int j = 0; j < digit.Length; j++)
            {
                if (int.Parse(digit[j].ToString()) % 2 != 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
