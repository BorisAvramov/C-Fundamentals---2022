using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Odd_Occurrences
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> words = Console.ReadLine().Split().Select(w => w.ToLower()).ToList();

            Dictionary<string, int> dictOccurances = new Dictionary<string, int>();

            for (int i = 0; i < words.Count; i++)
            {
                if (dictOccurances.ContainsKey(words[i]))
                {
                    dictOccurances[words[i]]++;
                }
                else
                {
                    dictOccurances.Add(words[i], 1);
                }


            }

            foreach (var word in dictOccurances)
            {
                if (word.Value %2 != 0)
                {
                    Console.Write(word.Key +" ");
                }
            }
            //List<string> wordsOddOcc = new List<string>();


            //foreach (var word in dictOccurances.Where(w=>w.Value % 2 != 0))
            //{
            //    wordsOddOcc.Add(word.Key);
            //}

            //Console.WriteLine(string.Join(" ", wordsOddOcc));

        }



    }
}
