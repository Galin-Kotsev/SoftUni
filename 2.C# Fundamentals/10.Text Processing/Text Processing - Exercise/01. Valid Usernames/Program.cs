using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = Console.ReadLine()
                .Split(", ");

            foreach (var user in userNames)
            {
                if (user.Length > 3 && user.Length <= 16)
                {
                    bool validUser = true;

                    foreach (char letter in user)
                    {
                        if (!(char.IsLetterOrDigit(letter) || letter == '-'
                            || letter == '_'))
                        {
                            validUser = false;
                            break;
                        }
                    }

                    if (validUser)
                    {
                        Console.WriteLine(user);
                    }
                }
            }

        }
    }
}
