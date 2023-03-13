using WildFarm.Bird;
using WildFarm.Mammal;

namespace WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input;
            List<Animal> animals = new List<Animal>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] animalInfo = input
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Animal animal = CreatingAnimal(animalInfo);

                string[] foodInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string food = foodInfo[0];
                double quantity = double.Parse(foodInfo[1]);

                animals.Add(animal);
                animal.Ask();
                animal.Feed(food, quantity);

            }

            foreach (var shit in animals)
            {
                Console.WriteLine(shit);
            }
        }

        private static Animal CreatingAnimal(string[] animalInfo)
        {
            if (animalInfo[0] == "Cat")
            {
                return new Cat(animalInfo[1], double.Parse(animalInfo[2]),
                          animalInfo[3], animalInfo[4]);
            }
            else if (animalInfo[0] == "Tiger")
            {
                return new Tiger(animalInfo[1], double.Parse(animalInfo[2]),
                          animalInfo[3], animalInfo[4]);
            }
            else if (animalInfo[0] == "Dog")
            {
                return new Dog(animalInfo[1], double.Parse(animalInfo[2]),
                          animalInfo[3]);
            }
            else if (animalInfo[0] == "Mouse")
            {
                return new Mouse(animalInfo[1], double.Parse(animalInfo[2]),
                          animalInfo[3]);
            }
            else if (animalInfo[0] == "Hen")
            {
                return new Hen(animalInfo[1], double.Parse(animalInfo[2]),
                          double.Parse(animalInfo[3]));
            }
            else if (animalInfo[0] == "Owl")
            {
                return new Owl(animalInfo[1], double.Parse(animalInfo[2]),
                          double.Parse(animalInfo[3]));
            }
            return null;
        }
    }
}