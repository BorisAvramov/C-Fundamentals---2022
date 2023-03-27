using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<string, int> keyMaterialDict = new Dictionary<string, int>();
            Dictionary<string, int> junkMaterialDict = new Dictionary<string, int>();

            string firstKeyMaterial = "";
            string legendaryItem = "";
            bool Target = false;
            while (!Target)
            {
                string[] input = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
               
                for (int i = 0; i < input.Length; i += 2)
                {
                    int quantity = int.Parse(input[i]);
                    string material = input[i + 1];
                    switch (material)
                    {
                        case "shards":
                        case "fragments":
                        case "motes":
                            if (!keyMaterialDict.ContainsKey(material))
                            {
                                keyMaterialDict.Add(material, quantity);
                            }
                            else
                            {
                                keyMaterialDict[material] += quantity;
                            }

                            if (keyMaterialDict[material] >= 250)
                            {
                                firstKeyMaterial = material;
                                
                                Target = true;
                                keyMaterialDict[firstKeyMaterial] -= 250;
                                if (!keyMaterialDict.ContainsKey("shards"))
                                {
                                    keyMaterialDict.Add("shards", 0);
                                }
                                if (!keyMaterialDict.ContainsKey("fragments"))
                                {
                                    keyMaterialDict.Add("fragments", 0);

                                }
                                if (!keyMaterialDict.ContainsKey("motes"))
                                {
                                    keyMaterialDict.Add("motes", 0);

                                }
                                switch (material)
                                {
                                    case "shards":
                                        legendaryItem = "Shadowmourne";
                                     
                                        break;
                                    case "fragments":
                                        legendaryItem = "Valanyr";
                                      ;
                                        break;
                                    case "motes":
                                        legendaryItem = "Dragonwrath";
                                        

                                        break;
                                    default:
                                        break;
                                }

                                Console.WriteLine($"{legendaryItem} obtained!");
                                
                                
                                
                            }
                            break;
                        default:
                            if (!junkMaterialDict.ContainsKey(material))
                            {
                                junkMaterialDict.Add(material, quantity);
                            }
                            else
                            {
                                junkMaterialDict[material] += quantity;
                            }

                            break;
                    }
                    if (Target)
                    {
                        break;
                    }
                }

              
                
            }

         
            foreach (var item in keyMaterialDict.OrderByDescending(x=>x.Value).ThenBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");


            }
            foreach (var item in junkMaterialDict.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
