﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Store_Boxes_SECOND_WAY
{
    class Item
    {
        public Item(string name, double price)
        {
            Name = name;
            Price = price;
        }
        public string Name { get; set; }
        public double Price { get; set; }

    }
}
