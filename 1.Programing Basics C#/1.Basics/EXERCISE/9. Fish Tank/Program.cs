using System;

namespace _9._Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volume = (length * width) * hight;

            

            double volumeLitre = volume * 0.001;

            

            double spaceUsage = percent * 0.01;

           

            double waterNeed = volumeLitre * (1 - spaceUsage);

            Console.WriteLine(waterNeed);



            

            
        }
    }
} 
