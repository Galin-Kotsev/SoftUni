using System;
using System.Collections.Generic;

namespace _07._Parking_Lot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tokens = string.Empty;

            HashSet<string> parkingLot 
                = new HashSet<string>();

            while ((tokens = Console.ReadLine()) != "END")
            {
                string[] details 
                    = tokens.Split(", ", StringSplitOptions.RemoveEmptyEntries);

                string direction = details[0];
                string carPlateNumber = details[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carPlateNumber);
                }

                if (direction == "OUT")
                {
                    parkingLot.Remove(carPlateNumber);
                }
            }

            if (parkingLot.Count > 0)
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
