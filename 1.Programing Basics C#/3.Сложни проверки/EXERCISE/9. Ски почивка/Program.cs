using System;

namespace _9._Ски_почивка
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string grade = Console.ReadLine();

            days = days - 1;
            double money = 0;

            if (roomType == "apartment")
            {
                money = days * 25.00;
                if (days > 10 && days <= 15)
                {
                    money = money - (money * 0.35);
                    if (grade == "positive")
                    {
                        money = money+(money * 0.25);
                        
                    }
                    else
                    {
                        money = money - (money * 0.10);
                        
                    }
                }
                else if (days > 15)
                {
                    money = money - (money * 0.50);
                    if (grade == "positive")
                    {
                        money = money + (money * 0.25);

                    }
                    else
                    {
                        money = money - (money * 0.10);

                    }
                }
                else
                {
                    money = money - (money * 0.30);
                    if (grade == "positive")
                    {
                        money = money + (money * 0.25);

                    }
                    else
                    {
                        money = money - (money * 0.10);

                    }
                }
            }
            if (roomType == "president apartment")
            {
                money = days * 35.00;
                if (days > 10 && days <= 15)
                {
                    money = money - (money * 0.15);
                    if (grade == "positive")
                    {
                        money = money + (money * 0.25);

                    }
                    else
                    {
                        money = money - (money * 0.10);

                    }
                }
                else if (days > 15)
                {
                    money = money - (money * 0.20);
                    if (grade == "positive")
                    {
                        money = money + (money * 0.25);

                    }
                    else
                    {
                        money = money - (money * 0.10);

                    }
                }
                else
                {
                    money = money - (money * 0.10);
                    if (grade == "positive")
                    {
                        money = money + (money * 0.25);

                    }
                    else
                    {
                        money = money - (money * 0.10);

                    }
                }
            }
            else if (roomType == "room for one person")
            {
                money = days * 18.00;
                if (grade == "positive")
                {
                    money = money + (money * 0.25);

                }
                else
                {
                    money = money - (money * 0.10);

                }
            }
            Console.WriteLine($"{money:f2}");

        }
    }
}
