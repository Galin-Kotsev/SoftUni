using System;
using System.Linq;

namespace _03._Count_Uppercase_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine(
               string.Join("\r\n", Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Where((s) => s[0].ToString().ToUpper()
                == s[0].ToString())
                .ToArray()));

            // Massive Porno Was made HERE !!!!
        }
    }
}
