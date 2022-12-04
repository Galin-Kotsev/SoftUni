using Microsoft.VisualBasic;
using System;
using System.Data;

namespace _01._Decrypting_Commands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Finish")
            {
                string[] inputs = input.Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string command = inputs[0];

                if (command == "Replace")
                {
                    string currChar = inputs[1];
                    string newChar = inputs[2];

                    text = text.Replace(currChar, newChar);

                    Console.WriteLine(text);
                }

                if (command == "Make")
                {
                    string command2 = inputs[1];

                    if (command2 == "Upper")
                    {
                        text = text.ToUpper();
                        Console.WriteLine(text);
                    }

                    if (command2 == "Lower")
                    {
                        text = text.ToLower();
                        Console.WriteLine(text);
                    }
                }

                if(command == "Check")
                {
                    string containedText = inputs[1];

                    if(text.Contains(containedText))
                    {
                        Console.WriteLine($"Message contains {containedText}");
                    }
                    else
                    {
                        Console.WriteLine($"Message doesn't contain {containedText}");
                    }
                }

                if (command == "Sum")
                {
                    int sum = 0;

                    int startIndex = int.Parse(inputs[1]);
                    int endIndex = int.Parse(inputs[2]);

                    if (startIndex >= 0 && endIndex < text.Length)
                    {
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            sum += text[i];
                        }

                        Console.WriteLine(sum);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }

                if (command == "Cut")
                {
                    int startIndex = int.Parse(inputs[1]);
                    int endIndex = int.Parse(inputs[2]);

                    if (startIndex >= 0 && endIndex < text.Length)
                    {
                        text = text.Remove(startIndex, endIndex - startIndex +1);

                        Console.WriteLine(text);
                    }
                    else
                    {
                        Console.WriteLine("Invalid indices!");
                    }
                }
            }
        }
    }
}
