using System;
using System.Linq;

namespace _06._Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            
            if (arr.Length == 1)
            {
                Console.WriteLine(0);
            }
            else
            {
                for (int i = 1; i < arr.Length; i++)
                {
                    int rightSum = 0;

                    for (int r = i+1; r < arr.Length; r++)
                    {

                        rightSum += arr[r];
                    }
                    int leftSum = 0;
                    for (int l = i - 1; l >= 0; l--)
                    {
                        leftSum += arr[l];
                    }
                    if (rightSum == leftSum)
                    {
                        Console.WriteLine(i);
                        return;
                    }
                }
                Console.WriteLine("no");

            }


        }
    }
}
