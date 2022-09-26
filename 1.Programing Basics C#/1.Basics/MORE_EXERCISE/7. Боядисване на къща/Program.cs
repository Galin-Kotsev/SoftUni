using System;

namespace _7._Боядисване_на_къща
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()); 
            double y = double.Parse(Console.ReadLine()); 
            double z = double.Parse(Console.ReadLine());
            
         // GREEN PAINT 
            //side wall
            double sidewallarea = x * y;
            //window area
            double windowArea = 1.5 * 1.5;
            //dualSide
            double dualSide = 2 * sidewallarea - 2 * windowArea;
            //backWall & door
            double door = 1.2 * 2;
            double backWall = x * x;
            //frontbackSide
            double frbkSide = 2 * backWall - door;
            //total area
            double totalArea = dualSide + frbkSide;
            //Green Pain
            double grPaint = totalArea / 3.4;

            //RED PAINT
            // Roof
            double roof = 2 * (x * y);
            //Triangle
            double triangle = 2 * (x * z / 2);
            //Total Area
            double totalArea2 = roof + triangle;
            //Fucking red Pain area
            double redPaint = totalArea2 / 4.3;
            // the Answer :D
            Console.WriteLine($"{grPaint:f2}");
            Console.WriteLine($"{redPaint:f2}");

        }
    }
}
