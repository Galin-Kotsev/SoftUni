using System;

namespace _01._Password_Reset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "Done")
            {
                string[] inputs = input.Split(' ');

                string command = inputs[0];

                if(command == "TakeOdd")
                {
                    string oldPassword = password;

                    password = string.Empty;

                    for (int i = 0; i < oldPassword.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            password += oldPassword[i];
                        }
                    }

                    Console.WriteLine(password);
                }

                if (command == "Substitute")
                {
                    string oldCh = inputs[1];
                    string newCh = inputs[2];

                    if (password.Contains(oldCh))
                    {
                        password = password.Replace(oldCh, newCh);

                        Console.WriteLine(password);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                }

                if (command == "Cut")
                {
                    int index1 = int.Parse(inputs[1]);    
                    int index2 = int.Parse(inputs[2]);    

                    password = password.Remove(index1, index2);

                    Console.WriteLine(password);
                }

            }

            Console.WriteLine($"Your password is: {password}");
        }
    }
}
