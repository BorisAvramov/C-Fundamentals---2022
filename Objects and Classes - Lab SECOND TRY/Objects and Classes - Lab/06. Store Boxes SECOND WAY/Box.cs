using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Store_Boxes_SECOND_WAY
{
    class Box
    {
        public Box(int serialNumber, Item item, int itemQuantity)
        {
             SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
        }

        public double PriceForABox 

        {
            get
            {
                return ItemQuantity * Item.Price;
            } 
        }
        

        public int SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }

       

    }
}
