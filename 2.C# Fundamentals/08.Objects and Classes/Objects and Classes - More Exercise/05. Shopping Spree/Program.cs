using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string people = Console.ReadLine();
            string product = Console.ReadLine();
            string input;

            List<Person> personsList = new List<Person>();
            List<Product> productList = new List<Product>();

            AddPeople(people, personsList);
     
            AddProducts(product, productList);

            while ((input = Console.ReadLine()) != "END")
            {
                string[] purches = input.Split(" ");
                string clientName = purches[0];
                string productPerches = purches[1];

                Person person
                    = personsList.FirstOrDefault(x => x.Name == clientName);

                Product product1
                    = productList.FirstOrDefault(y => y.ProductName == productPerches);

                if (person.Money >= product1.Cost)
                {
                    person.Money -= product1.Cost;
                    person.BagOfProducts.Add(product1);
                    Console.WriteLine($"{person.Name} bought {product1.ProductName}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product1.ProductName}");
                }
            }

            foreach (var person in personsList)
            {
                Console.WriteLine(person);
            }
        }

        private static void AddPeople(string people, List<Person> personsList)
        {
            string[] inputs = people.Split(";");

            for (int i = 0; i < inputs.Length; i++)
            {
                string[] personInput = inputs[i].Split("=", StringSplitOptions.RemoveEmptyEntries);
                string name = personInput[0];
                int money = int.Parse(personInput[1]);

                Person person
                    = new Person(name, money);

                personsList.Add(person);
            }
        }

        private static void AddProducts(string product, List<Product> productList)
        {
            string[] inputs = product.Split(";", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < inputs.Length; i++)
            {
                string[] productInput = inputs[i].Split("=");
                string productName = productInput[0];
                int cost = int.Parse(productInput[1]);

                Product products
                    = new Product(productName, cost);

                productList.Add(products);
            }
        }
    }
}
public class Person
{
    public Person(string name, int money)
    {
        Name = name;
        Money = money;
        BagOfProducts = new List<Product>();
    }

    public string Name { get; set; }
    public int Money { get; set; }
    public List<Product> BagOfProducts { get; set; }


    public override string ToString()
    {
        string result = Name + " - ";

        if (BagOfProducts.Count > 0)
        {
            result += string.Join(", ", BagOfProducts);
        }
        else
        {
            result += "Nothing bought";
        }

        return result;
    }
}
public class Product
{
    public Product(string productName, int cost)
    {
        ProductName = productName;
        Cost = cost;
    }

    public string ProductName { get; set; }
    public int Cost { get; set; }

    public override string ToString() => ProductName;
}