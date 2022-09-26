using System;

namespace _11._Магазин_за_плодове
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double endPrice = 0;

            if (day == "Saturday" || day == "Sunday")
            {
                if (product == "banana")
                {
                    endPrice=(2.70 * quantity);
                    Console.WriteLine($"{endPrice:f2}");

                }
                else if (product == "apple")
                {
                    endPrice = (1.25 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "orange")
                {
                    endPrice = (0.90 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "grapefruit")
                {
                    endPrice = (1.60 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "kiwi")
                {
                    endPrice = (3.00 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "pineapple")
                {
                    endPrice = (5.60 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "grapes")
                {
                    endPrice = (4.20 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else 
                {
                    Console.WriteLine("error");
                }
            }
            else if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
            {
                if (product == "banana")
                {
                    endPrice = (2.50 * quantity);
                    Console.WriteLine($"{endPrice:f2}");

                }
                else if (product == "apple")
                {
                    endPrice = (1.20 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "orange")
                {
                    endPrice = (0.85 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "grapefruit")
                {
                    endPrice = (1.45 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "kiwi")
                {
                    endPrice = (2.70 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "pineapple")
                {
                    endPrice = (5.50 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else if (product == "grapes")
                {
                    endPrice = (3.85 * quantity);
                    Console.WriteLine($"{endPrice:f2}");
                }
                else
                {
                    Console.WriteLine("error");
                }
            }
            else
                {
                    Console.WriteLine("error");
                }
            }
        }
    }

