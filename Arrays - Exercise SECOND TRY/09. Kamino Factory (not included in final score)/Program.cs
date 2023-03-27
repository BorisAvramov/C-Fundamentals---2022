using System;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Collections;

namespace _09._Kamino_Factory__not_included_in_final_score_
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenght = int.Parse(Console.ReadLine());


            int[] bestDnaArr = new int[lenght];
            int bestCount = 0;
            int maxIndex = 0;




            string input = Console.ReadLine();

            while (input != "Clone them!")
            {
                int[] currArr = input.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bestCurrCount = 0;

                for (int i = 0; i < currArr.Length; i++)
                {
                    int currCount = 0;
                    for (int j = i+1; j < currArr.Length; j++)
                    {
                        if (currArr[i] == 1 && currArr[j] == 1)
                        {
                            currCount++;
                        }


                    }
                    if (currCount > bestCurrCount)
                    {
                        bestCurrCount = currCount;
                    }
                    if (i > maxIndex)
                    {
                        maxIndex = i;
                    }

                }
                if (bestCurrCount > bestCount && )
                {
                    bestCount = bestCurrCount;
                }



                Console.WriteLine(string.Join(" ", bestDnaArr));
            }
        }
    }
}
