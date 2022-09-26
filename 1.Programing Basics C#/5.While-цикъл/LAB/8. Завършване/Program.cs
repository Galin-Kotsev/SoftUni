using System;

namespace _8._Завършване
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double avarege = 0;
            int badGrade = 0;
            int classes = 0;

            while (badGrade != 2 && classes !=12)
            {
                double grade = double.Parse(Console.ReadLine());

                if (grade < 4)
                {
                    badGrade++;
                }
                else
                {
                    avarege += grade;
                    classes++;
                }
                
                
            }

            if (classes == 12)
            {
                Console.WriteLine($"{name} graduated. Average grade: {avarege / classes:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {classes+1} grade");
            }
        }
    }
}
