using System;

namespace _3._Калкулатор_депозити
{
    class Program
    {
        static void Main(string[] args)
        {
           // Deposit input
           double deposit = double.Parse(Console.ReadLine());
           // Deposit time
           int time = int.Parse(Console.ReadLine());
           // Year Intrest Input
           double intrest = double.Parse(Console.ReadLine());
           
           //сума = депозирана сума  + срок на депозита * ((депозирана сума * годишен лихвен процент ) / 12)

            double sum = deposit + time*((deposit * intrest / 100) / 12);
            Console.WriteLine(sum);




        }
    }
}
