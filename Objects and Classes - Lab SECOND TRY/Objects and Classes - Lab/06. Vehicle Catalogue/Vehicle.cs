using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Vehicle_Catalogue
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.HorsePower = horsepower;



        }


        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }



    }
}
