using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> chest = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Yohoho!")
                {
                    break;
                }
                string[] data = input.Split(" ").ToArray();

                if (data[0] == "Loot")
                {
                    chest = GetLoot(data, chest);
                  
                }
                else if (data[0] == "Drop")
                {
                    if (int.Parse(data[1]) < 0 || int.Parse(data[1]) > chest.Count - 1)
                    {
                        continue;
                    }
                    chest = GetDrop(data, chest);
                }
                else if (data[0] == "Steal")
                {
                    PrintStealesd(data, chest);
                    chest = GetSteal(data, chest);
                   
                }

            }
            double averageTreGain = GetAvTrGain(chest);
            if (chest.Count == 0)
            {
                Console.WriteLine("Failed treasure hunt.");
            }
            else
            {
                PrintAverage(averageTreGain);

            }

        }

        private static void PrintAverage(double averageTreGain)
        {
            Console.WriteLine($"Average treasure gain: {averageTreGain:f2} pirate credits.");


        }

        private static double GetAvTrGain(List<string> chest)
        {
            double averageGain = 0;
            for (int i = 0; i < chest.Count; i++)
            {
                for (int j = 0; j < chest[i].Length; j++)
                {
                    averageGain++;
                }
            }

            return (averageGain / chest.Count);
        }

        private static void PrintStealesd(string[] data, List<string> chest)
        {
            List<string> stealed = new List<string>();
            if (int.Parse(data[1]) >= chest.Count)
            {
                for (int i = 0; i < chest.Count; i++)
                {
                    stealed.Add(chest[i]);
                }
            }
            else
            {
                for (int i = chest.Count - int.Parse(data[1]); i < chest.Count; i++)
                {
                    stealed.Add(chest[i]);
                }
            }
           
            Console.WriteLine(string.Join(", ", stealed));
        }

        private static List<string> GetSteal(string[] data, List<string> chest)
        {
            if (int.Parse(data[1]) >= chest.Count)
            {
                chest.RemoveRange(0, chest.Count);
            }
            else
            {
                int index = int.Parse(data[1]);
                chest.RemoveRange(chest.Count - index, index);
            }
            

            return chest;
        }

        private static List<string> GetDrop(string[] data, List<string> chest)
        {
            
            string temp = chest[int.Parse(data[1])];
            chest.RemoveAt(int.Parse(data[1]));
            chest.Add(temp);

            return chest;
        }

        private static void PrintChest(List<string> chest)
        {
            foreach (var item in chest)
            {
                Console.Write(item + " ");
            }
           
        }

        private static List<string> GetLoot(string[] data, List<string> chest)
        {
            for (int i = 1; i < data.Length; i++)
            {
                if (!chest.Contains(data[i]))
                {
                    chest.Insert(0, data[i]);
                }

            }

            return chest;
        }
    }
}
