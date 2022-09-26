using System;

namespace _7._Пазаруване
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //inputs :
            double budgetPeter = double.Parse(Console.ReadLine());
            double videoCarsPcs = double.Parse(Console.ReadLine());
            double processorPcs = double.Parse(Console.ReadLine());
            double ramPcs = double.Parse(Console.ReadLine());

            double videoSum = videoCarsPcs * 250;
            double processorPrice = videoSum * 0.35;
            double processorSum = processorPcs * processorPrice;
            double ramPrice = videoSum * 0.10;
            double ramSum = ramPcs * ramPrice;
            double totalSum = videoSum + processorSum + ramSum;
            

            if (videoCarsPcs > processorPcs)
            {
                double EndPrice = totalSum * 0.85;
                if (EndPrice <= budgetPeter)
                {
                    Console.WriteLine($"You have {budgetPeter - EndPrice:f2} leva left!");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {EndPrice-budgetPeter:f2} leva more!");
                }
            }
            else
            {
                if (totalSum <= budgetPeter)
                {
                    
                    Console.WriteLine($"You have {budgetPeter - totalSum:f2} leva left!");
                }
                else
                {
                    Console.WriteLine($"Not enough money! You need {totalSum - budgetPeter:f2} leva more!");
                }
            }
            
        }
    }
}
            

            
            





            


