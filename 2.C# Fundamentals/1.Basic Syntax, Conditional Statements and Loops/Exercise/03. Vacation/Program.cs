using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleAmount = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();


            double price = 0;

            if (groupType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    price = peopleAmount * 8.45;

                    if (peopleAmount >=30)
                    {
                        price = (peopleAmount * 8.45) * 0.85;
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = peopleAmount * 9.80;

                    if (peopleAmount >= 30)
                    {
                        price = (peopleAmount * 9.80) * 0.85;
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = peopleAmount * 10.46;

                    if (peopleAmount >= 30)
                    {
                        price = (peopleAmount * 10.46) * 0.85;

                    }
                }
            }
            else if (groupType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    price = peopleAmount * 10.90;

                    if (peopleAmount >= 100)
                    {
                        peopleAmount -= 10;
                        price = peopleAmount * 10.90;
                        
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = peopleAmount * 15.60;

                    if (peopleAmount >= 100)
                    {
                        peopleAmount -= 10;
                        price = peopleAmount * 15.60;
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = peopleAmount * 16;

                    if (peopleAmount >= 100)
                    {
                        peopleAmount -= 10;
                        price = peopleAmount * 16;
                    }
                }

            }
            else if (groupType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    price = peopleAmount * 15;

                    if (peopleAmount >= 10 && peopleAmount <= 20)
                    {
                        price = (peopleAmount * 15) * 0.95;
                    }
                }
                else if (dayOfWeek == "Saturday")
                {
                    price = peopleAmount * 20;

                    if (peopleAmount >= 10 && peopleAmount <= 20)
                    {
                        price = (peopleAmount * 20) * 0.95;
                    }
                }
                else if (dayOfWeek == "Sunday")
                {
                    price = peopleAmount * 22.50;

                    if (peopleAmount >= 10 && peopleAmount <= 20)
                    {
                        price = (peopleAmount * 22.50) * 0.95;
                    }
                }

            }

            Console.WriteLine($"Total price: {price:f2}");
        }
    }
}
