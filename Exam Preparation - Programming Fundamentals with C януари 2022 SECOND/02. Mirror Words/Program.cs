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
            string pattern = @"(@|#)(?<wordOne>[A-Za-z]{3,})\1{2}(?<wordTwo>[A-Za-z]{3,})\1";

            Regex regex = new Regex(pattern);

            string input = Console.ReadLine();

            MatchCollection matches = regex.Matches(input);


            if (matches.Count > 0)
            {
                Console.WriteLine($"{matches.Count} word pairs found!");
                List<string> list = new List<string>();
                bool mirrorWords = false;
                foreach (Match item in matches)
                {
                    string reversed = "";
                    for (int i = item.Groups["wordTwo"].Value.Length - 1; i >= 0; i--)
                    {
                        reversed += item.Groups["wordTwo"].Value[i];
                    }
                    if (item.Groups["wordOne"].Value == reversed)
                    {
                        mirrorWords = true;
                        list.Add($"{item.Groups["wordOne"].Value} <=> {item.Groups["wordTwo"].Value}");
                    }


                }
                if (mirrorWords)
                {
                    Console.WriteLine("The mirror words are:");
                    Console.WriteLine(string.Join(", ", list));
                }
                else
                {
                    Console.WriteLine("No mirror words!");
                }
                

            }
            else
            {
                Console.WriteLine("No word pairs found!");

                Console.WriteLine("No mirror words!");
            }

        }
    }
}
