using System;

namespace _2.__Лятно_облекло
{
    class Program
    {
        static void Main(string[] args)
        {
            int degree = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();
            string outfit = "";
            string shoes = "";

            switch (time)
            {
                case "Morning":

                    if (degree <= 18)
                    {
                        outfit = "Sweatshirt";
                        shoes = "Sneakers";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }

                break;
                case "Afternoon":
                    if (degree <= 18)
                    {
                        outfit = "Shirt";
                        shoes = "Moccasins";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else if (degree > 18 && degree <= 24)
                    {
                        outfit = "T-Shirt";
                        shoes = "Sandals";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    else
                    {
                        outfit = "Swim Suit";
                        shoes = "Barefoot";
                        Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    }
                    break;

                default:
                    outfit = "Shirt";
                    shoes = "Moccasins";
                    Console.WriteLine($"It's {degree} degrees, get your {outfit} and {shoes}.");
                    break;
            }


        }
    }
}
