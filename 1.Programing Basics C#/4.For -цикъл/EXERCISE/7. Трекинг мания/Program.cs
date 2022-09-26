using System;

namespace _7._Трекинг_мания
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 0; i < n; i++)
            {
                int claimers = int.Parse(Console.ReadLine());

                if (claimers <=5 )
                {
                    musala += claimers;
                }
                else if (claimers >= 6 && claimers <=12)
                {
                    monblan += claimers;
                }
                else if (claimers >=13 && claimers <=25)
                {
                    kilimandjaro += claimers;
                }
                else if (claimers >= 26 && claimers <= 40)
                {
                    k2 += claimers;
                }
                else
                {
                    everest += claimers;
                }
                
            }
            double sumClaiamers = musala + monblan + kilimandjaro + k2 + everest;
            musala = musala / sumClaiamers * 100;
            monblan = monblan / sumClaiamers * 100;
            kilimandjaro = kilimandjaro / sumClaiamers * 100;
            k2 = k2 / sumClaiamers * 100;
            everest = everest / sumClaiamers * 100;

            Console.WriteLine($"{musala:f2}%");
            Console.WriteLine($"{monblan:f2}%");
            Console.WriteLine($"{kilimandjaro:f2}%");
            Console.WriteLine($"{k2:f2}%");
            Console.WriteLine($"{everest:f2}%");


        }
    }
}
                
                
               

                
