using System;

namespace _3._Почивка
{
    class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double currentMoney = double.Parse(Console.ReadLine());
            string action = string.Empty;
            double usedMoney = 0;
            int pastDays = 0;
            int spendDays = 0;

             while (moneyNeeded >= currentMoney)
             {
                action = Console.ReadLine();
                usedMoney = double.Parse(Console.ReadLine());
                pastDays++;

                if (action == "spend")
                {
                    currentMoney -= usedMoney;
                    spendDays++;

                    if (currentMoney <= 0)
                    {
                        currentMoney = 0;
                    }
                }
                else if (action == "save")
                {

                    currentMoney += usedMoney;
                    spendDays = 0; // FUCK THIS SHIT !!!!!!
                }


                if (spendDays >= 5)
                {
                    Console.WriteLine("You can't save the money.");
                    Console.WriteLine($"{pastDays}");
                    break;
                }
                if (currentMoney >= moneyNeeded)
                {
                    Console.WriteLine($"You saved the money for {pastDays} days.");
                    break;
                }

            }
            
            
        }
    }
}
