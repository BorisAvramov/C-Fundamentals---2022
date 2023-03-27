using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Mirror_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string pattern = @"([@|#])(?<first>[a-zA-Z]{3,})\1{2}(?<second>[a-zA-Z]{3,})\1";

            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }
            List<string> list = new List<string>();

            foreach (Match item in matches)
            {
                string firstWord = item.Groups["first"].Value;
                string secondWord = item.Groups["second"].Value;
                string reversedSecond = "";
                for (int i = secondWord.Length - 1; i >= 0; i--)
                {
                    reversedSecond += secondWord[i];
                }

                if (firstWord == reversedSecond)
                {
                    string curPair = firstWord + " <=> " + secondWord;
                    list.Add(curPair); ;
                    
                }

            }
            if (list.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                Console.WriteLine(string.Join(", ", list));

            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
