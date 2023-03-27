using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace _04._Star_Enigma__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> AttackedPlanet = new List<string>();
            List<string> DestroyedPlanet = new List<string>();


            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();
                int countStar = 0;
                string lowerCase = input.ToLower().ToString(); 
                for (int j = 0; j < lowerCase.Length; j++)
                {
                    if (lowerCase[j] == 's' | lowerCase[j] == 't' | lowerCase[j] == 'a' | lowerCase[j] == 'r')
                    {
                        countStar++;
                    }


                }

                char[] inputArray = input.ToCharArray();
                string decryptString = "";
                for (int k = 0; k < inputArray.Length; k++)
                {
                    int intChar = (int)inputArray[k] - countStar;
                    inputArray[k] = (char)intChar;
                    decryptString += inputArray[k];

                }

                
                Match match = Regex.Match(decryptString, @"^.*@(?<planet>[A-Z][a-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*!(?<typeAttack>[A|D])![^@\-!:>]*->(?<soldiers>\d+).*$");

                if (match.Success)
                {
                    if (match.Groups["typeAttack"].Value == "A")
                    {
                        AttackedPlanet.Add(match.Groups["planet"].Value);
                    }
                    else
                    {
                        DestroyedPlanet.Add(match.Groups["planet"].Value);
                    }



                }

            }
            Console.WriteLine($"Attacked planets: {AttackedPlanet.Count}");
            foreach (var item in AttackedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");

            }
            Console.WriteLine($"Destroyed planets: {DestroyedPlanet.Count}");
            foreach (var item in DestroyedPlanet.OrderBy(x => x))
            {
                Console.WriteLine($"-> {item}");

            }
        }
    }
}
