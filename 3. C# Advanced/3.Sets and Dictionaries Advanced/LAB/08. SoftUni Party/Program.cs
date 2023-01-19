using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._SoftUni_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string guest = string.Empty;

            HashSet<string> reservationList 
                = new HashSet<string>();

            while((guest = Console.ReadLine()) != "END") 
            { 
                if(guest == "PARTY")
                {
                    while ((guest = Console.ReadLine()) != "END")
                    {
                        reservationList.Remove(guest);
                    }
                    break;
                }
                else
                {
                    reservationList.Add(guest);
                }
            }

            Console.WriteLine(reservationList.Count);
            foreach(string person in reservationList) 
            { 
                  Console.WriteLine(person);
            }
        }
    }
}
