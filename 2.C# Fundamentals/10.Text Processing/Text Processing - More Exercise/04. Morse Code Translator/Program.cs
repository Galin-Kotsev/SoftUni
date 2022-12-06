using System;

namespace _04._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string[] input 
                = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string decriptedMessaage 
                = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == ".-")
                {
                    decriptedMessaage += "A";
                }
                else if (input[i] == "-...")
                {
                    decriptedMessaage += "B";
                }
                else if (input[i] == "-.-.")
                {
                    decriptedMessaage += "C";
                }
                else if (input[i] == "-..")
                {
                    decriptedMessaage += "D";
                }
                else if (input[i] == ".")
                {
                    decriptedMessaage += "E";
                }
                else if (input[i] == "..-.")
                {
                    decriptedMessaage += "F";
                }
                else if (input[i] == "--.")
                {
                    decriptedMessaage += "G";
                }
                else if (input[i] == "....")
                {
                    decriptedMessaage += "H";
                }
                else if (input[i] == "..")
                {
                    decriptedMessaage += "I";
                }
                else if (input[i] == ".---")
                {
                    decriptedMessaage += "J";
                }
                else if (input[i] == "-.-")
                {
                    decriptedMessaage += "K";
                }
                else if (input[i] == ".-..")
                {
                    decriptedMessaage += "L";
                }
                else if (input[i] == "--")
                {
                    decriptedMessaage += "M";
                }
                else if (input[i] == "-.")
                {
                    decriptedMessaage += "N";
                }
                else if (input[i] == "---")
                {
                    decriptedMessaage += "O";
                }
                else if (input[i] == ".--.")
                {
                    decriptedMessaage += "P";
                }
                else if (input[i] == "--.-")
                {
                    decriptedMessaage += "Q";
                }
                else if (input[i] == ".-.")
                {
                    decriptedMessaage += "R";
                }
                else if (input[i] == "...")
                {
                    decriptedMessaage += "S";
                }
                else if (input[i] == "-")
                {
                    decriptedMessaage += "T";
                }
                else if (input[i] == "..-")
                {
                    decriptedMessaage += "U";
                }
                else if (input[i] == "...-")
                {
                    decriptedMessaage += "V";
                }
                else if (input[i] == ".--")
                {
                    decriptedMessaage += "W";
                }
                else if (input[i] == "-..-")
                {
                    decriptedMessaage += "X";
                }
                else if (input[i] == "-.--")
                {
                    decriptedMessaage += "Y";
                }
                else if (input[i] == "..--")
                {
                    decriptedMessaage += "Z";
                }
                else if (input[i] == "|")
                {
                    decriptedMessaage += " ";
                }
            }
            Console.WriteLine(decriptedMessaage);
        }
    }
}
