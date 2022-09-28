using System;

namespace _06._Bills
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mounts = int.Parse(Console.ReadLine());

            double electricalBill = 0;

            for (int i = 0; i < mounts; i++)
            {
                double electricity = double.Parse(Console.ReadLine());

                electricalBill += electricity;
            }

            double waterBill = 20 * mounts;
            double internetBull = 15 * mounts;
            double otherBill = (electricalBill + waterBill + internetBull) * 1.20;
            double averageBill = (otherBill + electricalBill + waterBill + internetBull) / mounts;

            Console.WriteLine($"Electricity: {electricalBill:f2} lv");
            Console.WriteLine($"Water: {waterBill:f2} lv");
            Console.WriteLine($"Internet: {internetBull:f2} lv");
            Console.WriteLine($"Other: {otherBill:f2} lv");
            Console.WriteLine($"Average: {averageBill:f2} lv");
        }
    }
}
