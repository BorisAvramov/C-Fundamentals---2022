using System;
using System.Collections.Generic;

namespace _03._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dictCityPop = new Dictionary<string, int>();
            Dictionary<string, int> dictCityGold = new Dictionary<string, int>();
            

            string input1 = Console.ReadLine();

            while (input1 != "Sail")
            {
                string[] data = input1.Split("||");
                string city = data[0];
                int popultaio = int.Parse(data[1]);
                int gold = int.Parse(data[2]);

                if (dictCityPop.ContainsKey(city))
                {
                    dictCityPop[city] += popultaio;
                    dictCityGold[city] += gold;
                }
                else
                {
                    dictCityPop.Add(city, popultaio);
                    dictCityGold.Add(city, gold);
                }


                input1 = Console.ReadLine();
            }

            string input2 = Console.ReadLine();
            while (input2 != "End")
            {
                string[] data = input2.Split("=>");
                string command = data[0];
                if (command == "Plunder")
                {
                    string city = data[1];
                    int pop = int.Parse(data[2]);
                    int gold = int.Parse(data[3]);

                    dictCityPop[city] -= pop;


                    dictCityGold[city] -= gold;


                    Console.WriteLine($"{city} plundered! {gold} gold stolen, {pop} citizens killed.");

                    if (dictCityGold[city] <= 0 || dictCityPop[city] <= 0)
                    {
                        dictCityPop.Remove(city);
                        dictCityGold.Remove(city);
                        Console.WriteLine($"{city} has been wiped off the map!");
                    }


                }
                else if (command == "Prosper")
                {
                    string city = data[1];
                    int gold = int.Parse(data[2]);

                    if (gold < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }
                    else
                    {
                        dictCityGold[city] += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {city} now has {dictCityGold[city]} gold.");
                    }
                }


                input2 = Console.ReadLine();
            }
            if (dictCityPop.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {dictCityGold.Count} wealthy settlements to go to: ");
                foreach (var city in dictCityPop)
                {
                    Console.WriteLine($"{city.Key} -> Population: {dictCityPop[city.Key]} citizens, Gold: {dictCityGold[city.Key]} kg");

                }

            }
            else
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
             

        }
    }
}
