using System;
using System.Linq;

namespace _02._Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            string first = input[0];
            string second = input[1];

            int totalSum = GetTotal(first, second);

            if (first.Length != second.Length)
            {
                string shorter = "";
                string longer = "";

                if (first.Length > second.Length)
                {
                    longer = first;
                    shorter = second;
                }
                else
                {
                    longer = second;
                    shorter = first;
                }
       
                for (int i = shorter.Length; i < longer.Length; i++)
                {
                    totalSum += longer[i];
                }
               
            }

            Console.WriteLine(totalSum);

        }
       
        private static int GetTotal(string first, string second)
        {
            int total = 0;
            for (int i = 0; i < first.Length; i++)
            {
                total += (int)first[i] * (int)second[i];
            }
            return total;

        }
    }
}
