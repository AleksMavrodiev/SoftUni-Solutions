using System;
using System.Collections.Generic;
using System.Linq;

namespace _6._StoreBoxes
{
    class Item
    {
        public Item(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }
    }

    class Box
    {
        public string SerialNumber { get; set; }
        public Item MyItem { get; set; }
        public int ItemQuantity { get; set; }
        public double BoxPrice
        {
            get { return MyItem.Price * ItemQuantity; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split();
                string serialNumber = cmdArgs[0];
                string itemName = cmdArgs[1];
                int itemQuantity = int.Parse(cmdArgs[2]);
                double itemPrice = double.Parse(cmdArgs[3]);
                Box newBox = new Box
                {
                    SerialNumber = serialNumber,
                    MyItem = new Item(itemName, itemPrice),
                    ItemQuantity = itemQuantity
                };
                boxes.Add(newBox);
            }
            boxes = boxes.OrderByDescending(i => i.BoxPrice).ToList();
            foreach (Box box in boxes)
            {
                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.MyItem.Name} - ${box.MyItem.Price:F2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.BoxPrice:F2}");
            }
        }
    }
}
