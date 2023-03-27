using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Plant_Discovery
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> plantRarity = new Dictionary<string, int>();
            Dictionary<string, List<int>> plantRatings = new Dictionary<string, List<int>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] data = Console.ReadLine().Split("<->");
                string plant = data[0];
                int rarity = int.Parse(data[1]);

                if (!plantRarity.ContainsKey(plant))
                {
                    plantRarity.Add(plant, rarity);
                    plantRatings.Add(plant, new List<int>());
                }
                else
                {
                    plantRarity[plant] = rarity;
                }


            }
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Exhibition")
                {
                    break;
                }

                string[] data = input.Split(new char[] {' ',':','-'},StringSplitOptions.RemoveEmptyEntries);
                string command = data[0];
                string plant = data[1];

                if (plantRarity.ContainsKey(plant) == false)
                {
                    Console.WriteLine("error");
                    continue;
                }
               
                if (command == "Rate")
                {
                    int rate = int.Parse(data[2]);
                    plantRatings[plant].Add(rate);
                }
                if (command == "Update")
                {
                    plantRarity[plant] = int.Parse(data[2]);
                }
                if (command == "Reset")
                {
                    plantRatings[plant].RemoveRange(0, plantRatings[plant].Count);


                }

            }
            Console.WriteLine("Plants for the exhibition:");
            foreach (var plant in plantRarity)
            {
                double averageRating = 0;
                if (plantRatings[plant.Key].Count > 0)
                {
                    averageRating = plantRatings[plant.Key].Average();
                }
                
                Console.WriteLine($"- {plant.Key}; Rarity: {plant.Value}; Rating: {averageRating:f2}");
            }

        }
    }
}
