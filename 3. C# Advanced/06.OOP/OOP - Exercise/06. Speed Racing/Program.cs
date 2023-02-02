namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main()
        {
            List<Car> cars 
                = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputs 
                    = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string model = inputs[0];
                double fuelAmount = double.Parse(inputs[1]);
                double fuelConsumptionPerKilometer = double.Parse(inputs[2]);

                cars.Add(new Car(model,fuelAmount,fuelConsumptionPerKilometer));
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string[] inputs = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = inputs[0];
                string model = inputs[1];
                double travelledDistance = double.Parse(inputs[2]); 

                if(command == "Drive")
                {
                    Car car = cars.FirstOrDefault(c => c.Model == model);
                 
                    car.Drive(travelledDistance);
                }
            }

            foreach  (Car car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.TravelledDistance}");
            }
        }
    }
}

