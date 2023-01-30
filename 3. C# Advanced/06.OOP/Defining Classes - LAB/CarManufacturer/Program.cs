using CarManufacturer;
using System.Reflection;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main()
        {
            List<Tire[]> tires
                = new();
            List<Engine> engines
                = new();
            List<Car> cars
                = new();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "No more tires")
            {
                string[] tireinfo
                    = input.Split(" ");

                int tire1Age = int.Parse(tireinfo[0]);
                double tire1press = double.Parse(tireinfo[1]);
                int tire2Age = int.Parse(tireinfo[2]);
                double tire2press = double.Parse(tireinfo[3]);
                int tire3Age = int.Parse(tireinfo[4]);
                double tire3press = double.Parse(tireinfo[5]);
                int tire4Age = int.Parse(tireinfo[6]);
                double tire4press = double.Parse(tireinfo[7]);

                tires.Add(new Tire[]
                {new Tire(tire1Age, tire1press), new Tire(tire2Age, tire2press),
             new Tire(tire3Age, tire3press), new Tire(tire4Age, tire4press)});
            }

            while ((input = Console.ReadLine()) != "Engines done")
            {
                string[] engineInfo
                    = input.Split(" ");

                int horsePower = int.Parse(engineInfo[0]);
                double cubicCapacity = double.Parse(engineInfo[1]);

                engines.Add(new Engine(horsePower, cubicCapacity));
            }


            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carInfo
                    = input.Split(" ");

                string make = carInfo[0];
                string model = carInfo[1];
                int year = int.Parse(carInfo[2]);
                double fuelQuantity = double.Parse(carInfo[3]);
                double fuelConsumption = double.Parse(carInfo[4]);
                int engineIndex = int.Parse(carInfo[5]);
                int tiresIndex = int.Parse(carInfo[6]);

                cars.Add
                    (new Car(make,
                    model,
                    year,
                    fuelQuantity,
                    fuelConsumption,
                    engines.ElementAt(engineIndex),
                    tires.ElementAt(tiresIndex))
                    );
            }

            foreach (Car car in cars)
            {
                double totalPressure = car.Tires[0].Pressure + car.Tires[1].Pressure
                     + car.Tires[2].Pressure + car.Tires[3].Pressure;

                if (car.Year >= 2017
                     && car.Engine.HorsePower > 330
                     && totalPressure >= 9 && totalPressure <= 10)
                {
                    car.Drive(20);

                    Console.WriteLine(car.WhoAmI());
                }
            }
        }
    }

}