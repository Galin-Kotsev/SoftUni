using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _03._Deck_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> cardDeck = Console.ReadLine()
                .Split(", ")
                .ToList();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(", ");
                string command = inputs[0];
                string card = inputs[1];


                if (command == "Add")
                {
                    if (!cardDeck.Contains(card))
                    {
                        cardDeck.Add(card);
                        Console.WriteLine("Card successfully added");
                    }
                    else
                    {
                        Console.WriteLine("Card is already in the deck");
                    }

                }
                else if (command == "Remove")
                {
                    if (cardDeck.Contains(card))
                    {
                        cardDeck.Remove(card);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Card not found");
                    }

                }
                else if (command == "Remove At")
                {
                    int index = int.Parse(card);

                    if (index >= 0 && index < cardDeck.Count)
                    {
                        cardDeck.RemoveAt(index);
                        Console.WriteLine("Card successfully removed");
                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }

                }
                else if (command == "Insert")
                {
                    int index = int.Parse(card);
                    string cardName = inputs[2];

                    if (index >= 0 && index < cardDeck.Count && cardDeck.Contains(cardName))
                    {
                        Console.WriteLine("Card is already added");
                    }
                    else if (index >= 0 && index < cardDeck.Count)
                    {
                        cardDeck.Insert(index, cardName);
                        Console.WriteLine("Card successfully added");

                    }
                    else
                    {
                        Console.WriteLine("Index out of range");
                    }
                }
            }

            Console.WriteLine(string.Join(", ", cardDeck));
        }
    }
}
