using System.Collections.Immutable;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<IBuyer> buyers = new List<IBuyer>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 3)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];
                    string birthdate = tokens[3];

                    buyers.Add(new Citizen(name, age, id, birthdate));
                }
                else 
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string group = tokens[2];

                    buyers.Add(new Rebel(name, age, group));
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                string name = input;

                IBuyer buyer = buyers.FirstOrDefault(x=> x.Name == name);

                if (buyer != null)
                {
                    buyer.BuyFood();
                }
            }

            int sum = 0;

            foreach (var buyer in buyers) 
            {
                sum += buyer.Food;
            }

            Console.WriteLine(sum);
        }
    }
}