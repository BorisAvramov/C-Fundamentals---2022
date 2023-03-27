using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Vehicle_Catalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            Brand = brand;
            Model = model;
            Weight = weight;
        }



        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }




    }
}
