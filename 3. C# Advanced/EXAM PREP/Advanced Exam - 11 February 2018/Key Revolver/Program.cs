using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Key_Revolver
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int gunBareelSize = int.Parse(Console.ReadLine());
            
            Stack<int> bullets 
                = new Stack<int>(Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)); 

            Queue<int> locks 
                = new Queue<int>(Console.ReadLine()
                .Split(" ")
                .Select(int.Parse));

            int money = int.Parse(Console.ReadLine());

            int count = 0;

            
            while (bullets.Count > 0 && locks.Count > 0) 
            {
                if (bullets.Peek() > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                    bullets.Pop();
                }
                else if (bullets.Peek() <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    bullets.Pop();
                    locks.Dequeue();
                }

                money -= bulletPrice;
                count++;

                if (gunBareelSize == count && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                    count = 0;
                    continue;
                }
            }

            if (bullets.Count == 0 && locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
       
            }

            if (locks.Count == 0)
            {
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${money}");
                
            }
        }
    }
} 