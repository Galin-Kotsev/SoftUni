using System;
using System.Linq;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] path = Console.ReadLine().Split("\\");

            string[] lastpath = path.Last().Split(".");

            string name = lastpath[0];  
            string extension = lastpath[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {extension}");
         
        }
    }
}
