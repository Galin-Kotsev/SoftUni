using System.Runtime.Intrinsics.X86;
using VehicleExtention;

namespace PolymorphismExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double fuelQuantity = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);
            double capacity = double.Parse(carInfo[3]);

            Car car = new Car(fuelQuantity, fuelConsumption, capacity);

            string[] truckInfo = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            fuelQuantity = double.Parse(truckInfo[1]);
            fuelConsumption = double.Parse(truckInfo[2]);
            capacity = double.Parse(truckInfo[3]);

            Truck truck = new Truck(fuelQuantity, fuelConsumption, capacity);

            string[] busInfo = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            fuelQuantity = double.Parse(busInfo[1]);
            fuelConsumption = double.Parse(busInfo[2]);
            capacity = double.Parse(busInfo[3]);

            Bus bus = new Bus(fuelQuantity, fuelConsumption, capacity);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine().Split(" ");

                if (tokens[1] == "Car")
                {
                    if (tokens[0] == "Drive")
                    {
                        car.Drive(double.Parse(tokens[2]));
                    }
                    else if (tokens[0] == "Refuel")
                    {
                        car.Refuel(double.Parse(tokens[2]));
                    }
                }
                else if (tokens[1] == "Truck")
                {
                    if (tokens[0] == "Drive")
                    {
                        truck.Drive(double.Parse(tokens[2]));
                    }
                    else if (tokens[0] == "Refuel")
                    {
                        truck.Refuel(double.Parse(tokens[2]));
                    }
                }
                else if (tokens[1] == "Bus")
                {
                    if (tokens[0] == "Drive")
                    {
                        bus.Drive(double.Parse(tokens[2]));
                    }
                    else if (tokens[0] == "Refuel")
                    {
                        bus.Refuel(double.Parse(tokens[2]));
                    }
                    else if(tokens[0] == "DriveEmpty")
                    {
                        bus.DriveEmpry(double.Parse(tokens[2]));
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}