using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Store_Boxes
{
    class Box
    {
        public Box(int serialNumber, string item, int itemQuantity, double priceForABox)
        {
            SerialNumber = serialNumber;
            Item = item;
            ItemQuantity = itemQuantity;
            PriceForABox = priceForABox;

        }
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public double PriceForABox { get; set; }

    }
}
