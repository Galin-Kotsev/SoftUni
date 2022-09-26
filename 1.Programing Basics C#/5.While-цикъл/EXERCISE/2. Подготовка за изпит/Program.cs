using System;

namespace _2._Подготовка_за_изпит
{
    class Program
    {
        static void Main(string[] args)
        {
            int badGradeLimit = int.Parse(Console.ReadLine());
            int task = 0;
            int badGrade = 0;
            double gradeScore = 0;
            string lastTask = string.Empty;

            while (badGrade < badGradeLimit)
            {
                string addedTask = Console.ReadLine();
                if ("Enough" == addedTask)
                {
                    break;
                }
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    badGrade++;
                }

                task++;
                gradeScore += grade;
                lastTask = addedTask;
            }

            if (badGradeLimit<=badGrade)
            {
                Console.WriteLine($"You need a break, {badGradeLimit} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {gradeScore/ task:f2}");
                Console.WriteLine($"Number of problems: {task}");
                Console.WriteLine($"Last problem: {lastTask}");
            }     

        }
    }
}
