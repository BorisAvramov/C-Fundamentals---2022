using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int bestCaunt = 0;
            int bestIndex = 0;



            for (int i = 0; i < arr.Length; i++)
            {
                int counter = 1;
                for (int j = i+1 ; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter > bestCaunt)
                {
                    bestCaunt = counter;
                    bestIndex = i;
                }

            }
            for (int i = 0; i < bestCaunt; i++)
            {
                Console.Write(arr[bestIndex] + " ");
            }

        }
    }
}
