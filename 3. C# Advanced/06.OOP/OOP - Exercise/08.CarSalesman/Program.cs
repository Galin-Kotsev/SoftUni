namespace _08.CarSalesman;

public class StartUp
{
    public static void Main()
    {
        List<Car> cars
            = new List<Car>();

        List<Engine> engines
           = new List<Engine>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] inputs
                = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = inputs[0];
            int power = int.Parse(inputs[1]);

            if (inputs.Length == 2)
            {
                engines.Add(new Engine(model, power));
            }
            else if (inputs.Length == 3)
            {
                if (char.IsDigit(inputs[2][0]))
                {
                    int displacement = int.Parse(inputs[2]);
                    engines.Add(new Engine(model, power, displacement));
                }
                else
                {
                    string efficiency = inputs[2];
                    engines.Add(new Engine(model, power, efficiency));
                }
            }
            else if (inputs.Length == 4)
            {
                int displacement = int.Parse(inputs[2]);
                string efficiency = inputs[3];

                engines.Add(new Engine(model, power, displacement, efficiency));
            }
        }

        int m = int.Parse(Console.ReadLine());

        for (int i = 0; i < m; i++)
        {
            string[] inputs
                = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string model = inputs[0];
            string engine = inputs[1];

            Engine engine1 = engines.FirstOrDefault(x => x.Model == engine);

            if (inputs.Length == 2)
            {
                cars.Add(new Car(model, engine1));
            }
            else if (inputs.Length == 3)
            {
                if (char.IsDigit(inputs[2][0]))
                {
                    int weight = int.Parse(inputs[2]);
                    cars.Add(new Car(model, weight, engine1));
                }
                else
                {
                    string color = inputs[2];

                    cars.Add(new Car(model, color, engine1));
                }
            }
            else if (inputs.Length == 4)
            {
                int weight = int.Parse(inputs[2]);
                string color = inputs[3];

                cars.Add(new Car(model, weight, color, engine1));
            }
        }

        foreach (Car car in cars)
        {
            Console.WriteLine($"{car.Model}:");
            Console.WriteLine($"  {car.Engine.Model}:");
            Console.WriteLine($"    Power: {car.Engine.Power}");
            if (car.Engine.Displacement == 0)
            {
                Console.WriteLine($"    Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"    Displacement: {car.Engine.Displacement}");
            }
            Console.WriteLine($"    Efficiency: {car.Engine.Efficiency}");
            if (car.Weight == 0)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {car.Weight}");
            }
            Console.WriteLine($"  Color: {car.Color}");
        }
    }
}
