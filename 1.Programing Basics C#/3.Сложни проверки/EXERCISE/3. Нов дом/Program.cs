using System;

namespace _3._Нов_дом
{
    class Program
    {
        static void Main(string[] args)
        {
            string flower = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double sum = 0;
            // ROSES
            if (flower == "Roses")
            {
                sum = quantity * 5;
                if (sum > budget)
                {
                    if (quantity > 80)
                    {
                        sum = sum - (sum * 0.10);
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                    }
                }
                else
                {
                    if (quantity > 80)
                    {
                        sum = sum - (sum * 0.10);
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                    }

                }

            }
            if (flower == "Dahlias")
            {
                sum = quantity * 3.80;
                if (sum > budget)
                {
                    if (quantity > 90)
                    {
                        sum = sum - (sum * 0.15);
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                    }
                }
                else
                {
                    if (quantity > 90)
                    {
                        sum = sum - (sum * 0.15);
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                    }

                }

            }
            if (flower == "Tulips")
            {
                sum = quantity * 2.80;
                if (sum > budget)
                {
                    if (quantity > 80)
                    {
                        sum = sum - (sum * 0.15);
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                    }
                    else
                    {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                    }
                }
                else
                {
                    if (quantity > 80)
                    {
                        sum = sum - (sum * 0.15);
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                    }
                    else
                    {
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                    }

                }

            }
            if (flower == "Narcissus")
            {
                sum = quantity * 3.00;
                if (quantity < 120)
                {
                    sum = sum + (sum * 0.15);
                }

                if (sum > budget)
                {
                        Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                }
                else
                {
                        Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");

                }

            }
            if (flower == "Gladiolus")
            {
                sum = quantity * 2.50;

                if (quantity < 80)
                {
                    sum = sum + (sum * 0.20);
                }

                if (sum > budget)
                {
                    Console.WriteLine($"Not enough money, you need {Math.Abs(sum - budget):f2} leva more.");
                }
                else
                {
                    Console.WriteLine($"Hey, you have a great garden with {quantity} {flower} and {Math.Abs(sum - budget):f2} leva left.");
                }

            }

        }
    }
}


