using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            double horsePowerCar = 0;
            double horsePowerTruck = 0;
            int countCars = 0;
            int countTrucks = 0;

            while (true)
            {
                string inpjt = Console.ReadLine();
                if (inpjt == "End")
                {
                    break;

                }
                string[] data = inpjt.Split().ToArray();

                vehicles.Add(new Vehicle(data[0], data[1], data[2],int.Parse(data[3]) ));
                if (data[0] == "car")
                {
                    countCars++;
                    horsePowerCar += int.Parse(data[3]);
                }
                else
                {
                    countTrucks++; ;
                    horsePowerTruck += int.Parse(data[3]);

                }

            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Close the Catalogue")
                {
                    break;
                }
                foreach (var vehicle in vehicles.Where(v=>v.Model == input))
                {
                    if (vehicle.Type == "car")
                    {
                        Console.WriteLine($"Type: Car");
                    }
                    else
                    {
                        Console.WriteLine($"Type: Truck");
                    }
                    
                    Console.WriteLine($"Model: {vehicle.Model}");
                    Console.WriteLine($"Color: {vehicle.Color}");
                    Console.WriteLine($"Horsepower: {vehicle.HorsePower}");

                }

            }
            Console.WriteLine($"Cars have average horsepower of: {(horsePowerCar / countCars):f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {(horsePowerTruck / countTrucks):f2}.");



        }
    }

    

    
}



