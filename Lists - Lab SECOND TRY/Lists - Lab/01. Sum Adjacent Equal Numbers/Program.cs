﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Sum_Adjacent_Equal_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();

            GetResult(input);

            
        }

        private static void GetResult(List<double> input)
        {
            for (int i = 0; i < input.Count - 1; i++)
            {
                if (i + 1 == input.Count)
                {
                    break;
                }
                if (input[i] == input[i + 1])
                {

                    input[i] += input[i + 1];
                    input.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ", input));


        }
    }
}