using System.Collections.Immutable;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = string.Empty;

            List<IIdentifable> Ids = new List<IIdentifable>();

            while ((input = Console.ReadLine()) != "End")
            {
                string[] tokens = input
                    .Split(" ",StringSplitOptions.RemoveEmptyEntries);

                if (tokens.Length > 2)
                {
                    string name = tokens[0];
                    int age = int.Parse(tokens[1]);
                    string id = tokens[2];

                    Ids.Add(new Citizen(name, age, id));
                }
                else
                {
                    string name = tokens[0];
                    string id = tokens[1];

                    Ids.Add(new Robot(name, id));
                }
            }

            string idSearch = Console.ReadLine();

            foreach (var i in Ids)
            {
                if (i.Id.ToString().EndsWith(idSearch))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}