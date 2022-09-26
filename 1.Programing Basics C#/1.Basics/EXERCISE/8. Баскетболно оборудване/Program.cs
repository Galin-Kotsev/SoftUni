using System;

namespace _8._Баскетболно_оборудване
{
    class Program
    {
        static void Main(string[] args)
        {
            int taxFee = int.Parse(Console.ReadLine());

            double shoes = taxFee - (taxFee * 0.4);


            double outFit = shoes - (shoes * 0.20);

            double ball = outFit / 4;
            

            double accessories = ball / 5;
            

            double sum = taxFee + shoes + outFit + ball + accessories;

            Console.WriteLine(sum);
        }
    }
}
