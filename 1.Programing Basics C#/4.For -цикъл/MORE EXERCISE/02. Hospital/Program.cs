using System;

namespace _02._Hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());

            int patientsTre = 0;
            int patientUnt = 0;
            int doctors = 7;


            for (int i = 1; i <= period; i++)
            {
                Calculations(ref patientsTre, ref patientUnt, ref doctors, i);

            }

            Console.WriteLine($"Treated patients: {patientsTre}.");
            Console.WriteLine($"Untreated patients: {patientUnt}.");
        }

        private static void Calculations(ref int patientsTre, ref int patientUnt, ref int doctors, int i)
        {
            int patients = int.Parse(Console.ReadLine());

            if (i % 3 == 0)
            {
                if (patientsTre < patientUnt)
                {
                    doctors++;
                }
            }

            if (patients > doctors)
            {
                patientsTre += doctors;
                patients -= doctors;
                patientUnt += patients;

            }
            else if (patients <= doctors)
            {

                patientsTre += patients;
            }
        }
    }
}
