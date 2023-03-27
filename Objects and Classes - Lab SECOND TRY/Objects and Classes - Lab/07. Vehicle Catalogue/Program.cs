using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vehicle_Catalogue
{
    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            Brand = brand;
            Model = model;
            HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }

    }
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
    class Catalog
    {
        public Catalog(List<Truck> trucks, List<Car> cars)
        {
            Trucks = trucks;
            Cars = cars;

        }


        public List<Truck> Trucks { get; set; }

        public List<Car> Cars { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                string[] inputArr = input.Split('/');

                string type = inputArr[0];
                string brand = inputArr[1];
                string model = inputArr[2];
                if (type == "Truck")
                {
                    int weight = int.Parse(inputArr[3]);
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
                else
                {
                    int horsePower = int.Parse(inputArr[3]);
                    Car car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }

            }

            Catalog catalog = new Catalog(trucks, cars);

            if (catalog.Cars.Count > 0)
            {
                Console.WriteLine("Cars:");
       
                foreach (var car in catalog.Cars.OrderBy(c=>c.Brand))
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
                }
            }
            if (catalog.Trucks.Count >0)
            {
                Console.WriteLine("Trucks:");
                foreach (var truck in catalog.Trucks.OrderBy(t=>t.Brand))
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }

        }
    }
}
