using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Ad_Astra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(#|\|)(?<itemName>[a-zA-Z ]+)\1(?<expDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>[0-9][0-9]{0,3}|10000)\1";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);
            List<int> caloriesList = new List<int>();

            if (matches.Count == 0)
            {
                Console.WriteLine("You have food to last you for: 0 days!");
            }
            else
            {
                foreach (Match item in matches)
                {
                    caloriesList.Add(int.Parse(item.Groups["calories"].Value));
                }
                double days = Math.Floor(caloriesList.Sum() / 2000.0);
                Console.WriteLine($"You have food to last you for: {days} days!");
                foreach (Match item in matches)
                {
                    Console.WriteLine($"Item: {item.Groups["itemName"].Value}, Best before: {item.Groups["expDate"].Value}, Nutrition: {item.Groups["calories"].Value}");

                }
            }
            

        }
    }
}
