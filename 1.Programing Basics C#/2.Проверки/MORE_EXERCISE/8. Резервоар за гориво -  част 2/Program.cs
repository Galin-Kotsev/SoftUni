using System;

namespace _8._Резервоар_за_гориво____част_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double liters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            if (fuelType == "Gas")       
            {
                if (clubCard == "Yes")
                {
                    liters = (liters * 0.85);

                    if (liters >= 20 && liters <= 25)
                    {
                        liters = liters - (liters * 0.08);
                        Console.WriteLine($"{liters:f2} lv.");
                    }
                    else if (liters > 25)
                    {
                        liters = liters - (liters * 0.10);
                        Console.WriteLine($"{liters:f2} lv.");
                    }
                }
                else
                {
                    liters = liters * 0.93;
                    if (liters >= 20 && liters <= 25)
                    {
                        liters = liters - (liters * 0.08);
                        
                    }
                    else if (liters > 25)
                    {
                        liters = liters - (liters * 0.10);
                       
                    }
                    
                    Console.WriteLine($"{liters:f2} lv.");
                }
            }
            else if (fuelType == "Diesel")
            {
                if (clubCard == "Yes")
                {
                    liters = (liters * 2.21);

                    if (liters >= 20 && liters <= 25)
                    {
                        liters = liters - (liters * 0.08);
                        Console.WriteLine($"{liters:f2} lv.");
                    }
                    else if (liters > 25)
                    {
                        liters = liters - (liters * 0.10);
                        Console.WriteLine($"{liters:f2} lv.");
                    }
                }
                else
                {
                    liters = liters * 2.33;
                    if (liters >= 20 && liters <= 25)
                    {
                        liters = liters - (liters * 0.08);
                        
                    }
                    else if (liters > 25)
                    {
                        liters = liters - (liters * 0.10);
                       
                    }
                    
                    Console.WriteLine($"{liters:f2} lv.");
                }
            }
            else 
            {
                if (clubCard == "Yes")
                {
                    liters = (liters * 2.04);

                    if (liters >= 20 && liters <= 25)
                    {
                        liters = liters - (liters * 0.08);
                        Console.WriteLine($"{liters:f2} lv.");
                    }
                    else if (liters > 25)
                    {
                        liters = liters - (liters * 0.10);
                        Console.WriteLine($"{liters:f2} lv.");
                    }
                }
                else
                {
                    liters = liters * 2.22;
                    if (liters >= 20 && liters <= 25)
                    {
                        liters = liters - (liters * 0.08);
                        
                    }
                    else if (liters > 25)
                    {
                        liters = liters - (liters * 0.10);
                        
                    }
                    
                    Console.WriteLine($"{liters:f2} lv.");
                }
            }
        }
    }
}
