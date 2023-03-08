namespace PolymorphismExercise
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] carInfo = Console.ReadLine().Split(" ");

            double fuelQuantity = double.Parse(carInfo[1]);
            double fuelConsumption = double.Parse(carInfo[2]);

            Car car = new Car(fuelQuantity, fuelConsumption);

            string[] truckInfo = Console.ReadLine().Split(" ");

            fuelQuantity = double.Parse(truckInfo[1]);
            fuelConsumption = double.Parse(truckInfo[2]);

            Truck truck = new Truck(fuelQuantity, fuelConsumption);

            string[] busInfo = Console.ReadLine().Split(" ");

            fuelQuantity = double.Parse(busInfo[1]);
            fuelConsumption = double.Parse(busInfo[2]);

            Bus bus = new Bus(fuelQuantity, fuelConsumption);

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
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}