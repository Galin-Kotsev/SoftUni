using System;

namespace _2._Еднакви_суми_на_четни_и_нечетни_позиции
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string classes = Console.ReadLine();

            double sum = 0;
            double totalSum = 0;
            int classSum = 0;


            while (classes != "Finish")
            {
                double grades = 0;
                double grade = 0;

                while (grades != n)
                {
                    grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    totalSum += grade;
                    grades++;
                }

                if (grades >= n)
                {
                    Console.WriteLine($"{classes} - {sum / n:f2}.");
                    sum = 0;

                }

                classes = Console.ReadLine();
                classSum++;
            }


            if (classes == "Finish")
            {
                totalSum /= n;
                Console.WriteLine($"Student's final assessment is {(totalSum) / classSum:f2}.");
            }
        }
    }
}
