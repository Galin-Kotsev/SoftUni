using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Member> members = new List<Member>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string name = inputs[0];
                int age = int.Parse(inputs[1]);

                Member member = new Member(name, age);

                members.Add(member);
            }

            foreach (var member in members.OrderByDescending(x => x.Age).Take(1))
            {
                Console.WriteLine(member);
            }
           
        }
    }
}

public class Member
{
    public Member(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }
}
