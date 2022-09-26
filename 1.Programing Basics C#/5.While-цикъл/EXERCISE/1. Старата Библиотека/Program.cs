using System;

namespace _1._Старата_Библиотека
{
    class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();

            string nextBook = Console.ReadLine();
            int books = 0;

            while (nextBook != "No More Books")
            {
                if (nextBook == favoriteBook)
                {
                  
                    break;
                }
                
                nextBook = Console.ReadLine();
                books++;

            }
            if (nextBook == favoriteBook)
            {
                Console.WriteLine($"You checked {books} books and found it.");
               
            }
            else
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {books} books.");
            }
        }
    }
}
