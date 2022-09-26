using System;
using System.Numerics;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string bestBall = string.Empty;

            BigInteger snowballValue = int.MinValue;

            for (int i = 0; i < n; i++)
            {
                int snowballSnow, snowballTime, snowballQuality;
                BigInteger Value;
                SnowBallQuality(out snowballSnow, out snowballTime, out snowballQuality, out Value);

                if (Value > snowballValue)
                {
                    saveValue(out bestBall, out snowballValue, snowballSnow, snowballTime, snowballQuality, Value);
                }

            }

            Console.WriteLine(bestBall);
        }

        private static void saveValue(out string bestBall, out BigInteger snowballValue, int snowballSnow, int snowballTime, int snowballQuality, BigInteger Value)
        {
            bestBall = $"{snowballSnow} : {snowballTime} = {Value} ({snowballQuality})";
            snowballValue = Value;
        }

        private static void SnowBallQuality(out int snowballSnow, out int snowballTime, out int snowballQuality, out BigInteger Value)
        {
            snowballSnow = int.Parse(Console.ReadLine());
            snowballTime = int.Parse(Console.ReadLine());
            snowballQuality = int.Parse(Console.ReadLine());

            Value = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
        }
    }
}
