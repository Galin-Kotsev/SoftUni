using System;
using System.Linq;

namespace _01._Secret_Chat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] inputs = input.Split(":|:");

                string command = inputs[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(inputs[1]);

                    text = text.Insert(index, " ");

                    Console.WriteLine(text);
                }

                if (command == "Reverse")
                {
                    string substring = inputs[1];

                    if (text.Contains(substring))
                    {
                        string oldSubstring = substring;
                        string reversedString = string.Empty;

                        for (int i = substring.Length - 1; i >= 0; i--)
                        {
                            reversedString += substring[i];
                        }
                        text = ReplaceFirst(text, oldSubstring, "");
                        
                        text += reversedString;

                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("error");

                    }
                }

                if (command == "ChangeAll")
                {
                    string oldCh = inputs[1];
                    string newCh = inputs[2];

                    if (text.Contains(oldCh))
                    {
                        text = text.Replace(oldCh, newCh);

                        Console.WriteLine(text);
                    }
                }
            }

            Console.WriteLine($"You have a new text message: {text}");
        }

        public static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
