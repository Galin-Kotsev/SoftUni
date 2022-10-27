using System;
using System.Collections.Generic;

namespace _03._Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

           List<Song> Songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] credentials = Console.ReadLine().Split('_'); 
                
                string type = credentials[0];
                string name = credentials[1];   
                string time = credentials[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                Songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if(typeList == "all")
            {
                foreach (Song song in Songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in Songs)
                {
                    if(song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
                
            }
        }
    }
}

class Song
{
    public string TypeList { get; set; } 
    public string Name { get; set; }    
    public string Time { get; set; }  

}
