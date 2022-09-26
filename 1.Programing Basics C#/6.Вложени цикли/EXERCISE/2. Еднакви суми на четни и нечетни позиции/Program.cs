using System;

namespace _2._Еднакви_суми_на_четни_и_нечетни_позиции
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                string currentNum = i.ToString();
                int oddTotal = 0;
                int evenTotal = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentDigit = int.Parse(currentNum[j].ToString());
                    if (j%2==0)
                    {
                        evenTotal += currentDigit;
                    }
                    else
                    {
                        oddTotal += currentDigit;
                    }
                }
                if (oddTotal == evenTotal)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
