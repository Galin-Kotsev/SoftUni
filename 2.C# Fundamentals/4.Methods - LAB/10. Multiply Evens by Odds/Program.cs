using System;
using System.Linq;

namespace _10._Multiply_Evens_by_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {

            char[] array = Console.ReadLine().ToCharArray();
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (char.IsDigit(array[i]))
                {
                    int num = int.Parse(array[i].ToString());

                    if (array[i] % 2 == 0)
                    {
                        evenSum += num;
                    }
                    else
                    {
                        oddSum += num;
                    }
                }
            }
            int sum = evenSum * oddSum;

            Console.WriteLine(sum);







        }
    }
}
