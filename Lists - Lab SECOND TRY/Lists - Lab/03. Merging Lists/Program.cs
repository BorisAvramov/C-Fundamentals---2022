using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstList = ReadList();
            List<int> secondList = ReadList();
            int lenghtShortList = GetLenght(firstList, secondList);
            List<int> longestList = GetLongestList(firstList, secondList);
            List<int> newList = GetNewList(firstList, secondList, lenghtShortList, longestList);

            Console.WriteLine(string.Join(" ", newList));
        }

        private static List<int> GetNewList(List<int> firstList, List<int> secondList, int lenghtShortList, List<int> longestList)
        {
            List<int> newList = new List<int>();
            if (firstList.Count != secondList.Count)
            {
                for (int i = 0; i <= lenghtShortList - 1; i++)
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);

                }
                for (int i = lenghtShortList; i <= longestList.Count - 1; i++)
                {
                    newList.Add(longestList[i]);
                }

            }
            else
            {
                for (int i = 0; i <= firstList.Count - 1; i++)
                {
                    newList.Add(firstList[i]);
                    newList.Add(secondList[i]);

                }
            }
            return newList;
        }

        private static List<int> GetLongestList(List<int> firstList, List<int> secondList)
        {
            List<int> longestList = new List<int>();
            if (firstList.Count > secondList.Count)
            {
                longestList = firstList;
            }
            else
            {
                longestList = secondList;
            }
            return longestList;
        }

        private static int GetLenght(List<int> firstList, List<int> secondList)
        {
            int lenght = 0;
            if (firstList.Count > secondList.Count)
            {
                lenght = secondList.Count;
            }
            else
            {
                lenght = firstList.Count;
            }
            return lenght;
        }

        private static List<int> ReadList()
        {
            List<int> List = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            return List;
        }
    }
}
