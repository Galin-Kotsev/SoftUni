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

            List<string> guestAtTheParty 
                = new List<string>();

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

            foreach (string vip in reservationList)
            {
                if (char.IsDigit(vip[0])) 
                {
                    guestAtTheParty.Add(vip);
                }
            }

            foreach (string normal in reservationList)
            {
                if (char.IsLetter(normal[0]))
                {
                    guestAtTheParty.Add(normal);
                }
            }

            Console.WriteLine(reservationList.Count);

            foreach(string person in guestAtTheParty) 
            { 
                  Console.WriteLine(person);
            }
        }
    }
}
