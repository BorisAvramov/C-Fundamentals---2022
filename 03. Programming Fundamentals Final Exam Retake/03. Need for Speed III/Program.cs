using System;
using System.Collections.Generic;

namespace _03._Need_for_Speed_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Dictionary<string, int[]> carMileageFuel = new Dictionary<string, int[]>();
            for (int i = 0; i < num; i++)
            {
                string[] data = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries);
                string curCar = data[0];
                int curMileage = int.Parse(data[1]);
                int curFuel = int.Parse(data[2]);

                if (!carMileageFuel.ContainsKey(curCar))
                {
                    carMileageFuel.Add(curCar, new int[2]);
                    carMileageFuel[curCar][0] = curMileage;
                    carMileageFuel[curCar][1] = curFuel;
                }
            }
            while (true)
            {
                string inpit = Console.ReadLine();
                if (inpit == "Stop")
                {
                    break;
                }
                string[] data = inpit.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                string car = data[1];

                if (command == "Drive")
                {
                    int distance = int.Parse(data[2]);
                    int fuelNeeded = int.Parse(data[3]);
                    if (fuelNeeded > carMileageFuel[car][1])
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                    }
                    else
                    {
                        carMileageFuel[car][0] += distance;
                        carMileageFuel[car][1] -= fuelNeeded;
                        Console.WriteLine($"{car} driven for {distance} kilometers. {fuelNeeded} liters of fuel consumed.");
                    }
                    if (carMileageFuel[car][0] >= 100000)
                    {
                        carMileageFuel.Remove(car);
                        Console.WriteLine($"Time to sell the {car}!");
                    }
                }
                if (command == "Refuel")
                {
                    int fuelToFill = int.Parse(data[2]);
                    int filledLitteres = 0;
                    if ((fuelToFill + carMileageFuel[car][1]) <= 75)
                    {
                        filledLitteres = fuelToFill;
                    }
                    else
                    {
                        filledLitteres = 75 - carMileageFuel[car][1];
                    }
                    carMileageFuel[car][1] += filledLitteres;
                    Console.WriteLine($"{car} refueled with {filledLitteres} liters");
                }
                if (command == "Revert")
                {
                    int kilToDecrease = int.Parse(data[2]);
                    Console.WriteLine($"{car} mileage decreased by {kilToDecrease} kilometers");
                    if ((carMileageFuel[car][0] - kilToDecrease) < 10000 )
                    {
                        carMileageFuel[car][0] = 10000;
                    }
                    else
                    {
                        carMileageFuel[car][0] -= kilToDecrease;
                    }


                }

            }

            foreach (var car in carMileageFuel)
            {
                Console.WriteLine($"{car.Key} -> Mileage: {car.Value[0]} kms, Fuel in the tank: {car.Value[1]} lt.");

            }

        }
    }
}
