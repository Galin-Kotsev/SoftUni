using System;
using System.Collections.Generic;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var employeeList = new Dictionary<string, List<string>>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[]inputs = input.Split(" -> ");

                string company = inputs[0];
                string id = inputs[1];

                if (!employeeList.ContainsKey(company))
                {
                    employeeList.Add(company, new List<string>());
                }

                if (!employeeList[company].Contains(id))
                {
                    employeeList[company].Add(id);
                } 

                input = Console.ReadLine();
            }

            foreach (var (company, id) in employeeList)
            {
                Console.WriteLine(company);

                foreach (var item in id)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}
