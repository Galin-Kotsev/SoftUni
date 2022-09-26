using System;

namespace _6._Операции_между_числа
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            string operate = Console.ReadLine();
            double result = 0;

            if (operate == "+" || operate == "-" || operate == "*")
            {
                if (operate == "+")
                {
                    result = n1 + n2;

                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} + {n2} = {result} - odd");
                    }
                }
                else if (operate == "-")
                {
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} - {n2} = {result} - odd");
                    }
                }
                else if (operate == "*")
                {
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - even");
                    }
                    else
                    {
                        Console.WriteLine($"{n1} * {n2} = {result} - odd");
                    }
                }
            }
            else if (operate == "/" || operate == "%" || n2 == 0)
            {
                if (n2 !=0)
                {
                    if (operate == "/")
                    {
                        result = n1 / n2;
                        Console.WriteLine($"{n1} / {n2} = {result:f2}");

                    }
                    else if (operate == "%")
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                }
                else
                {
                    Console.WriteLine($"Cannot divide {n1} by zero");
                }
                
            }

        }
    }
}
