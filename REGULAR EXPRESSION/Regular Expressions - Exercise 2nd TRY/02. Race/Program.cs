using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    class Program
    {
        static void Main(string[] args)
            {

            string paternLetters = @"[A-Za-z]";
            string paternDigits = @"[0-9]";
            string[] participants = Console.ReadLine().Split(", ").ToArray();
            Dictionary<string, double> dictNameDistance = new Dictionary<string, double>();
            
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "end of race")
                {
                    break;
                }
                string name = "";
                double distance = 0;
                MatchCollection matchName = Regex.Matches(input, paternLetters);
                
                foreach  (Match letter in matchName)
                {
                    name += letter.Value;
                }
                MatchCollection matchDistance = Regex.Matches(input, paternDigits);
                
                foreach (Match digit in matchDistance)
                {
                    distance += int.Parse(digit.Value);
                    

                }
                if (participants.Contains(name))
                {
                    if (!dictNameDistance.ContainsKey(name))
                    {
                        dictNameDistance.Add(name, distance);
                    }
                    else
                    {
                        dictNameDistance[name] += distance;
                    }
                   
                }
                
            }

            Dictionary<String, Double> RESULT = dictNameDistance.OrderByDescending(X => X.Value).ToDictionary(X=>X.Key, X=>X.Value);


            Console.WriteLine($"1st place: {RESULT.Keys.ElementAt(0)}");
            Console.WriteLine($"2nd place: {RESULT.Keys.ElementAt(1)}");
            Console.WriteLine($"3rd place: {RESULT.Keys.ElementAt(2)}");


            //2 НАЧИН ====================================================================================================
            //int count = 1;
            //foreach (var item in dictNameDistance.OrderByDescending(x=>x.Value).Take(3))
            //{

            //    string place = (count == 1? "st" : count == 2? "nd" : "rd");
            //    Console.WriteLine($"{count}{place} place: {item.Key}");
            //    count++;
            //}



            //---------------------------------------------------------------------------------------------
           //3 НАЧИН //int counter = 1;

            //foreach (var kvp in dictNameDistance.OrderByDescending(x=>x.Value))
            //{
            //    if (counter == 1)
            //    {
            //        Console.WriteLine($"1st place: {kvp.Key}");
            //    }
            //    else if (counter == 2)
            //    {
            //        Console.WriteLine($"2nd place: {kvp.Key}");
            //    }
            //    else if (counter == 3)
            //    {
            //        Console.WriteLine($"3rd place: {kvp.Key}");
            //    }
            //    else
            //    {
            //        break;
            //    }
            //    counter++;
            //}



        }
    }
}
