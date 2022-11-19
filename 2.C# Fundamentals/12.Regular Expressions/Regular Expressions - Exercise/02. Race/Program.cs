using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> inputs = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, int> participants= new Dictionary<string, int>();

            foreach (var name in inputs)
            {
                participants.Add(name, 0);
            }

            string input;

            while((input = Console.ReadLine()) != "end of race")
            {
                string name = string.Empty;
                int km = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (char.IsLetter(input[i]))
                    {
                        name += input[i];
                    }
                    else if(char.IsDigit(input[i]))
                    {
                        km += int.Parse(input[i].ToString());
                    }
                }

                if (participants.ContainsKey(name))
                {
                    participants[name] += km;
                }

            }

            int place = 1;

            foreach (var (Key,Value) in participants.OrderByDescending(x => x.Value).Take(3))
            {
                string order = string.Empty;

                if (place == 1)
                {
                    order = "1st";
                }
                else if (place == 2)
                {
                    order = "2nd";
                }
                else
                {
                    order = "3rd";
                }
                
                Console.WriteLine($"{order} place: {Key}");
                place++;

            }
        }
    }
}
