using System;
using System.Text.RegularExpressions;

namespace _02._Boss_Rush
{
    class Program
    {
        static void Main(string[] args)
        {
            string patter = @"\|(?<Boss>[A-Z]{4,})\|:#(?<Title>[a-zA-Z]+ [a-zA-Z]+)#";

            Regex regex = new Regex(patter);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                if (regex.IsMatch(input))
                {
                    Match curMatch = regex.Match(input);
                    Console.WriteLine($"{curMatch.Groups["Boss"].Value}, The {curMatch.Groups["Title"].Value}");
                    Console.WriteLine($">> Strength: {curMatch.Groups["Boss"].Length}");
                    Console.WriteLine($">> Armor: {curMatch.Groups["Title"].Length}");
                }
                else
                {
                    Console.WriteLine("Access denied!");
                }


            }

        }
    }
}
