using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] condensed = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                condensed[i] = nums[i] + nums[i + 1];

            }

        }
    }
}
