using System;

namespace _01._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = new string[7];

            days[0] = "Monday";
            days[1] = "Tuesday";
            days[2] = "Wednesday";
            days[3] = "Thursday";
            days[4] = "Friday";
            days[5] = "Saturday";
            days[6] = "Sunday";

            int number = int.Parse(Console.ReadLine());

            if (number > 7 || number < 1)
            {
                Console.WriteLine("Invalid day!");
            }
            else 
            {
                Console.WriteLine(days[number-1]);
            }

        }
    }
}
