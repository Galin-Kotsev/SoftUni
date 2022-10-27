using System;

namespace _01._Randomize_Words
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] sentance = Console.ReadLine().Split(' ');

            Random random = new Random();
            int randomIndex = random.Next(0, sentance.Length);


            for (int i = 0; i < sentance.Length; i++)
            {
                string word = sentance[i];
                string newWord = sentance[randomIndex];

                sentance[i] = newWord;
                sentance[randomIndex] = word;
            }

            Console.WriteLine(string.Join(Environment.NewLine,sentance));
        }
    }
}
