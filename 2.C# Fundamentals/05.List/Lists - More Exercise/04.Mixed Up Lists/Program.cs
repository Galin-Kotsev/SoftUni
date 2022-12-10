using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Mixed_Up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list1 
                = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            List<int> list2
                = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .Reverse()
                .ToList();

            List<int> mixedList = new List<int>();
            List<int> indexes = new List<int>();
            List<int> endList = new List<int>();


            if(list1.Count > list2.Count)
            {
                for (int i = 0; i < list2.Count; i++)
                {
                    mixedList.Add(list1[i]);
                    mixedList.Add(list2[i]);
                }

              indexes.AddRange(list1.Skip(list2.Count));
                
            }
            else if(list1.Count < list2.Count)
            {
                for (int k = 0; k < list1.Count; k++)
                {
                    mixedList.Add(list1[k]);
                    mixedList.Add(list2[k]);
                }

                indexes.AddRange(list2.Skip(list1.Count));
            }

            int index1 = 0;
            int index2 = 0;

            if (indexes[0] > indexes[1])
            {
                index1 = indexes[1];
                index2 = indexes[0];
            }
            else if (indexes[1] > indexes[0])
            {
                index1 = indexes[0];
                index2 = indexes[1];
            }

            for (int i = 0; i < mixedList.Count; i++)
            {
                if (mixedList[i] > index1 && mixedList[i] < index2)
                {
                    endList.Add(mixedList[i]);
                }
            }

            Console.WriteLine(string.Join(" ", endList.OrderBy(x=>x)));
        }
    }
}
