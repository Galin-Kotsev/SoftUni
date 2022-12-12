using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Oldest_Family_Member__2_Solution_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(" ");

                string name = inputs[0];
                int age = int.Parse(inputs[1]);

                Member member = new Member(name, age);
                family.AddMeber(member);
            }

            Console.WriteLine(family.GetOldestMember());
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

    public override string ToString() => $"{Name} {Age}";
}

public class Family
{
    public Family()
    {}
    public List<Member> Members = new List<Member>();

    public void AddMeber(Member member)
    {
        Members.Add(member);
    }

    public Member GetOldestMember() => Members.OrderByDescending(x => x.Age).First();
}