using System;

namespace _5_2._Suitcases_Load
{
    class Program
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            int count = 0;
            double totalValue = 0;

            while (command != "End")
            {
                double added = double.Parse(command);
               
                if (value < totalValue+added)
                {
                    Console.WriteLine("No more space!");
                    break;
                }
                else if (value < totalValue + added * 1.1 && count == 2)
                {
                    Console.WriteLine("No more space!");
                    break;
                }

                count++;
                if (count%3 ==0)
                {
                    totalValue += added * 1.1;
                }
                else
                {
                    totalValue += added;
                }
                
                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Congratulations! All suitcases are loaded!");
            }

            Console.WriteLine($"Statistic: {count} suitcases loaded.");
        }
    }
}
