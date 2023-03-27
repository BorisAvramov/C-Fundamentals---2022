using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            List<int> intList = new List<int>();
            int sum = 0;

            for (int i = 0; i < input.Length; i++)
            {
                sum += input[i];


            }
            double average = sum / input.Length;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > average)
                {
                    intList.Add(input[i]);
                }


            }

            if (intList.Count == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                foreach (var item in intList.OrderByDescending(x => x).Take(5))
                {

                    Console.Write(item + " ");

                }
            }
            
        }
    }
}
