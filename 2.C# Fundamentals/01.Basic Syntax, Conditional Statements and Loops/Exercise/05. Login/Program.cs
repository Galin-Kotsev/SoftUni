using System;

namespace _05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string account = Console.ReadLine();
            string password = String.Empty;

            int errorCount = 0;

            for (int i = account.Length - 1; i >= 0; i--)
            {
                password += account[i];
            }

            string input = Console.ReadLine();

            while (input != password)
            {
                errorCount++;

                if (errorCount == 4)
                {
                    Console.WriteLine($"User { account} blocked!");
                    return;
                }

                Console.WriteLine($"Incorrect password. Try again.");
                input = Console.ReadLine();
            }
            Console.WriteLine($"User { account} logged in.");
        }
    }
}

//string na = "ASD";
//string na2 = new string(na.Reverse().ToArray());



//Console.WriteLine(na2);