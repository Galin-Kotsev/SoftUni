using System;
using System.Linq;

namespace _01._The_Imitation_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string encryptedMessage = Console.ReadLine();

            string input;
            while ((input = Console.ReadLine()) != "Decode")
            {
                string[] inputs = input.Split("|");
                string command = inputs[0];

                if (command == "ChangeAll")
                {
                    string oldCh = inputs[1];
                    string newCh = inputs[2];

                    encryptedMessage = encryptedMessage.Replace(oldCh, newCh);
                }
                else if (command == "Move")
                {
                    int n = int.Parse(inputs[1]);

                    for (int i = 0; i < n; i++)
                    {
                        string ch = encryptedMessage.First().ToString();
                        encryptedMessage += ch;
                        encryptedMessage = encryptedMessage.Substring(1, encryptedMessage.Length - 1);
                    }
                }
                else if (command == "Insert")
                {
                    int index = int.Parse(inputs[1]);
                    string ch = inputs[2];

                    encryptedMessage = encryptedMessage.Insert(index, ch);
                }
            }
            Console.WriteLine($"The decrypted message is: {encryptedMessage}");
        }
    }
}
