using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();

            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] inputs = input.Split();
                int serialNumber = int.Parse(inputs[0]);
                string itemName = inputs[1];
                int itemQty = int.Parse(inputs[2]);
                double itemPrice = double.Parse(inputs[3]);

                Item item = new Item(itemName, itemPrice);

                Box box = new Box(serialNumber, item, itemQty);
                boxes.Add(box);

                input = Console.ReadLine();
            }

            foreach (var box in boxes.OrderByDescending(x => x.PriceForBox))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQty}");
                Console.WriteLine($"-- ${box.PriceForBox:f2}");
            }
        }
    }
}

public class Item
{
    public Item(string name, double price)
    {
        Name = name;
        Price = price;
    }
    public string Name { get; set; }
    public double Price { get; set; }

}
public class Box
{
    public Box(int serialNumber, Item item, int itemQty)
    {
        SerialNumber = serialNumber;
        Item = item;
        ItemQty = itemQty;
    }

    public int SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQty { get; set; }

    public double PriceForBox
    {
        get
        {
            return ItemQty * Item.Price;
        }
    }
}


