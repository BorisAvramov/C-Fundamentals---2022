using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, PopulationGold> townPopulationGold = new Dictionary<string, PopulationGold>();

            string targetCitues = Console.ReadLine();
            while (targetCitues != "Sail")
            {
                string [] data = targetCitues.Split("||");
                string town = data[0];
                int population = int.Parse(data[1]);
                int gold = int.Parse(data[2]);

                if (!townPopulationGold.ContainsKey(town))
                {
                    townPopulationGold.Add(town, new PopulationGold(population, gold));

                }
                else
                {
                    townPopulationGold[town].Population += population;
                    townPopulationGold[town].Gold += gold;
                }
                targetCitues = Console.ReadLine();

            }
            while (true)
            {
                string events = Console.ReadLine();
                if (events == "End")
                {
                    break;
                }

                string[] data = events.Split("=>");

                string command = data[0];
                string town = data[1];

                if (command == "Plunder")
                {
                    
                    Console.WriteLine($"{town} plundered! {int.Parse(data[3])} gold stolen, {int.Parse(data[2])} citizens killed.");
                    townPopulationGold[town].Population -= int.Parse(data[2]);
                    townPopulationGold[town].Gold -= int.Parse(data[3]);
                    if (townPopulationGold[town].Population == 0 || townPopulationGold[town].Gold == 0)
                    {
                        Console.WriteLine($"{town} has been wiped off the map!");
                        townPopulationGold.Remove(town);

                    }
                }
                if (command == "Prosper")
                {
                    int gold = int.Parse(data[2]);
                    if (gold < 0)
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                        continue;
                    }
                    else
                    {
                        townPopulationGold[town].Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {town} now has {townPopulationGold[town].Gold} gold.");
                    }


                }

            }

            if (townPopulationGold.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {townPopulationGold.Count} wealthy settlements to go to:");
                foreach (var item in townPopulationGold)
                {
                    Console.WriteLine($"{item.Key} -> Population: {item.Value.Population} citizens, Gold: {item.Value.Gold} kg");
                }

            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }
    }

    class PopulationGold
    {
        public PopulationGold(int population, int gold)
        {
            Population = population;
            Gold = gold;
        }
        public int Population { get; set; }
        public int Gold { get; set; }

    }


}
