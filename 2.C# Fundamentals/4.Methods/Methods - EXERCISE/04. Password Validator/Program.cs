using System;
using System.Collections.Generic;

namespace _04._Password_Validator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            bool charCheck = CharCheck(password);
            bool digitCheck = DigitCheck(password);
            bool minimalDigits = MinimalDigits(password);

            // Password Validation

            if (charCheck && digitCheck && minimalDigits)
            {
                Console.WriteLine($"Password is valid");
            }
        }

        private static bool MinimalDigits(string password)
        {
            int digitCheck = 0;

            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if (char.IsDigit(ch))
                {
                    digitCheck++;
                }
            }

            if (digitCheck < 2)
            {
                Console.WriteLine($"Password must have at least 2 digits");
                return false;
            }
            else
            {
                return true;
            }

        }

        private static bool DigitCheck(string password)
        {
            //Password Digit & Letter Check.

            bool letterDigitsCheck = true;

            for (int i = 0; i < password.Length; i++)
            {
                char ch = password[i];

                if (!char.IsLetterOrDigit(ch))
                {
                    letterDigitsCheck = false;
                }

            }

            if (letterDigitsCheck == false)
            {
                Console.WriteLine($"Password must consist only of letters and digits");
                return false;
            }
            else
            {
                return true;
            }

        }

        private static bool CharCheck(string password)
        {
            //Password Charecter LengthCheck.

            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
        }
    }
}
