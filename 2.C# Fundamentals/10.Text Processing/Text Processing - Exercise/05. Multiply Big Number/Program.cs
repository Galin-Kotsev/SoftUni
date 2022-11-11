using System;
using System.Numerics;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BigInteger n1 = BigInteger.Parse(Console.ReadLine());
           BigInteger n2 = BigInteger.Parse(Console.ReadLine());

           BigInteger result = n1 * n2;
            
            Console.WriteLine(result);


           // I'll USE BIGINTEGER , IM MY OWN BOSS !!!
        }
    }
}

