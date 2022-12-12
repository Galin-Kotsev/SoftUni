using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Department> departments = new List<Department>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string name = inputs[0];
                double salary = double.Parse(inputs[1]);
                string departmentName = inputs[2];

                Employee employee = new Employee(name, salary, departmentName);

                Department department = departments.FirstOrDefault(x => x.Name == departmentName);

                if (department == null)
                {
                    departments.Add(new Department(departmentName));
                }

                departments.First(x => x.Name == departmentName)
                    .Employees.Add(employee);
            }

            Department bestDepartment = departments.OrderByDescending(x => x.AverageSalary).First();

            Console.WriteLine($"Highest Average Salary: {bestDepartment.Name}");

            foreach (var employee in bestDepartment.Employees.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine(employee);
            }
        }
    }
}
public class Employee
{
    public Employee(string name, double salary, string department)
    {
        Name = name;
        Salary = salary;
        Department = department;
    }

    public string Name { get; set; }
    public double Salary { get; set; }
    public string Department { get; set; }

    public override string ToString() => $"{Name} {Salary:f2}";
}

public class Department
{
    public Department(string name)
    {
        Name = name;
        Employees = new List<Employee>();
    }

    public string Name { get; set; }
    public List<Employee> Employees { get; set; }

    public double AverageSalary => Employees.Sum(x => x.Salary) / Employees.Count;
}