using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Vehicle_Catalogue
{
    class Catalog
    {
        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;

        }
        
       
        public List <Truck> Trucks { get; set; }

        public  List<Car> Cars { get; set; }


    }
}
