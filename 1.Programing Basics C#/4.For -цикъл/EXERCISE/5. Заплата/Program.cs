using System;

namespace _5._Заплата
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());
            


            for (int i = 0; i < n; i++)
            {
                string webdomain = Console.ReadLine();
                if (webdomain == "Facebook")
                {
                    salary -= 150;
                }
                else if (webdomain == "Instagram")
                {
                    salary -= 100;
                }
                else if (webdomain == "Reddit")
                {
                    salary -= 50;
                }

                if (salary <=0)
                {
                    Console.WriteLine("You have lost your salary.");
                    return;
                }
            }
            Console.WriteLine(salary);
         }

    }
}
