using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrey1 = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
            

            int n = int.Parse(Console.ReadLine());
 
            for (int i = 0; i < n; i++)
            {

                int[] arrey2 = new int[arrey1.Length];
                int firstNum = arrey1[0];
                arrey1.Skip(1).ToArray().CopyTo(arrey2, 0);
                arrey2[arrey2.Length - 1] = firstNum;
                arrey1 = arrey2;
            }


            Console.WriteLine(String.Join(" ", arrey1));
        }
    }
}



