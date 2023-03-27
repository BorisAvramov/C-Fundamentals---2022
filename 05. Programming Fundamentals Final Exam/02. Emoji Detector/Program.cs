using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace _02._Emoji_Detector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"(:{2}|\*{2})(?<emoji>[A-Z][a-z]{2,})\1";
            string digitPattern = @"\d";

            long coolTreshold = 1;
            List<string> coolOnes = new List<string>();
            Regex regex = new Regex(pattern);
            Regex regexDigits = new Regex(digitPattern);

            MatchCollection emojisMatches = regex.Matches(input);

            MatchCollection digitsMatches = regexDigits.Matches(input);

            foreach (Match item in digitsMatches)
            {
                coolTreshold *= int.Parse(item.Value);

            }
            foreach (Match item in emojisMatches)
            {
                int currSum = 0;
                string name = item.Groups["emoji"].Value;
                for (int i = 0; i < name.Length; i++)
                {

                    currSum += name[i];

                }
                if (currSum > coolTreshold)
                {
                    coolOnes.Add(item.Value);
                }



            }

            Console.WriteLine($"Cool threshold: {coolTreshold}");
            Console.WriteLine($"{emojisMatches.Count} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", coolOnes));




        }
    }
}
