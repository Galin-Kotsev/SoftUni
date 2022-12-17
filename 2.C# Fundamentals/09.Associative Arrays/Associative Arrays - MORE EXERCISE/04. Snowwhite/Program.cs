using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;

            var dwarfList = new List<Dwarf>();

            while ((input = Console.ReadLine()) != "Once upon a time")
            {
                string[] inputs = input.Split(" <:> ");

                string dwarfName = inputs[0];
                string dwarfHatColor = inputs[1];
                int dwarfPshysics = int.Parse(inputs[2]);

                Dwarf dwarf
                    = dwarfList.FirstOrDefault
                    (x => x.DwarfName == dwarfName && x.DwarfHatColor == dwarfHatColor);

                if(dwarf == null)
                {
                    dwarfList.Add(new Dwarf(dwarfName, dwarfHatColor, dwarfPshysics));
                }
                else
                {
                    if (dwarfPshysics > dwarf.DwarfPshysics)
                    {
                        dwarf.DwarfPshysics = dwarfPshysics;
                    }
                }
            }

            foreach (var item in dwarfList
                .OrderByDescending(x => x.DwarfPshysics)
                .ThenByDescending(x => dwarfList.Where(y => y.DwarfHatColor == x.DwarfHatColor).Count()))
            {
                Console.WriteLine($"({item.DwarfHatColor}) {item.DwarfName} <-> {item.DwarfPshysics}");
            }
        }
    }
}
public class Dwarf
{
    public Dwarf(string dwarfName, string dwarfHatColor, int dwarfPshysics)
    {
        DwarfName = dwarfName;
        DwarfHatColor = dwarfHatColor;
        DwarfPshysics = dwarfPshysics;
    }

    public string DwarfName { get; set; }
    public string DwarfHatColor { get; set; }
    public int DwarfPshysics { get; set; }

}
