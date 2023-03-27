using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Real_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = Console.ReadLine().Split().Select(int.Parse).ToList();
            Dictionary<int, int> dict = new Dictionary<int, int>();

            for (int i = 0; i < intList.Count; i++)
            {
                if (dict.ContainsKey(intList[i]))
                {
                    dict[intList[i]]++;
                }
                else
                {
                    dict.Add(intList[i], 1);
                }
                

            }
            var sortedDict = dict.OrderBy(n => n.Key);
            foreach (var item in sortedDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            //foreach (var num in dict.OrderBy(n => n.Key))
            //{
            //    Console.WriteLine($"{num.Key} -> {num.Value}");
            //}
        }
    }
}
