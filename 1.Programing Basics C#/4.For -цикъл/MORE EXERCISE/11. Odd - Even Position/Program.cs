using System;

namespace _11._Odd___Even_Position
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            string result = string.Empty;
            string result2 = string.Empty;
            string result3 = string.Empty;
            string result4 = string.Empty;

            for (int i = 1; i <= n; i++)
            {
                double add = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenSum += add;

                    if (add > evenMax)
                    {
                        evenMax = add;
                    }
                    
                    if (add < evenMin)
                    {
                        evenMin = add;
                    }
                }
                else
                {
                    oddSum += add;

                    if (add > oddMax)
                    {
                        oddMax = add;
                    }
                    
                    if (add < oddMin)
                    {
                        oddMin = add;
                    }
                }
            }
           
            if (oddMin == 0 || oddMin == double.MaxValue)
            {
                result += "No";
            }
            else
            {
                result += $"{oddMin:f2}";
            }

            if (oddMax == 0 || oddMax == double.MinValue)
            {
                result2 += "No";
            }
            else
            {
                result2 += $"{oddMax:f2}";

            }
            

            if(evenMin == 0 || evenMin == double.MaxValue)
            {
                result3 += "No";
            }
            else
            {
                result3 += $"{evenMin:f2}";
            }

            if (evenMax == 0 || evenMax == double.MinValue)
            {
                result4 += "No";
            }
            else
            {
                result4 += $"{evenMax:f2}";

            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            Console.WriteLine($"OddMin={result:f2},");
            Console.WriteLine($"OddMax={result2:f2},");
            Console.WriteLine($"EvenSum={evenSum:f2},");
            Console.WriteLine($"EvenMin={result3:f2},");
            Console.WriteLine($"EvenMax={result4:f2}");
        }
    }
}
// HATE JUDGE !!!!