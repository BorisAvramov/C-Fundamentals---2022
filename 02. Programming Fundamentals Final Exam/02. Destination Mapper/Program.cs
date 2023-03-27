using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Destination_Mapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(=|\/)(?<Destination>[A-Z][a-zA-Z]{2,})\1";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            //MatchCollection matches2 = Regex.Matches(input, pattern);
            List<string> listMatches = new List<string>();
            foreach (Match item in matches)
            {
                listMatches.Add(item.Groups["Destination"].Value);
            }
            int points = 0;
            foreach (var item in listMatches)
            {
                points += item.Length;

            }

            Console.Write("Destinations: ");
            Console.Write(string.Join(", ", listMatches));
            Console.WriteLine();
            Console.WriteLine($"Travel Points: {points}");


        }
    }
}
