using System;
using System.Security.Cryptography.X509Certificates;

namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();

            string sentance = Console.ReadLine();

            string endWord = string.Empty;

            while (sentance.Contains(keyWord))
            {
                sentance = sentance.Remove(sentance.IndexOf(keyWord), keyWord.Length);
            }

            Console.WriteLine(sentance);
        }
    }
}
