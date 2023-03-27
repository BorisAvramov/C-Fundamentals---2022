using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }
                string[] inputArr = input.Split();
                int serialNumber = int.Parse(inputArr[0]);
                string itemName = inputArr[1];
                int itemQuantity = int.Parse(inputArr[2]);
                double itemPrice = double.Parse(inputArr[3]);
                double priceForABox = itemQuantity * itemPrice;

                
                Box box = new Box(serialNumber, itemName, itemQuantity, priceForABox);
                boxes.Add(box);
                

            }
            List<Box> orderedListBoxes = boxes.OrderByDescending(b => b.PriceForABox).ToList();
            foreach (var box in orderedListBoxes)
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item} - ${(box.PriceForABox / box.ItemQuantity):f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.PriceForABox:f2}");
            }

        }
    }
}
