using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Information> info = new List<Information>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] inputs = input.Split();
                string name = inputs[0];
                string id = inputs[1];
                int age = int.Parse(inputs[2]);

                if (info.Any(x => x.ID == id))
                {
                    var person = info.First(x => x.ID == id);
                    person.Age = age;
                    person.Name = name;   
                }
                else
                {
                    Information information = new Information(name, id, age);
                    info.Add(information);
                }

                input = Console.ReadLine();
            }

            foreach (var Information in info.OrderBy(x => x.Age))
            {
                Console.WriteLine($"{Information.Name} with ID:{Information.ID} is {Information.Age} years old.");
            }
        }
    }
}

public class Information
{
    public Information(string name, string id, int age)
    {
        Name = name;
        ID = id;
        Age = age;
    }

    public string Name { get; set; }
    public string ID { get; set; }
    public int Age { get; set; }
}
