using System;
using System.Linq;
using System.Collections.Generic;

namespace _4._Largest_3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var ints = Console.ReadLine().Split().Select(int.Parse).OrderByDescending(i => i).Take(3).ToList();

            Console.Write(string.Join(" ", ints));





            //2. for (int i = 0; i < (ints.Count >= 3 ? 3 : ints.Count); i++)
            // {
            //     Console.Write(ints[i] + " ");
            // }






            //3. if (ints.Count <= 3)
            //{
            //    for (int i = 0; i < ints.Count; i++)
            //    {
            //        Console.Write(ints[i] + " ");
            //    }

            //}
            //else
            //{
            //    for (int i = 0; i <= 2; i++)
            //    {
            //        Console.Write(ints[i] + " ");
            //    }
            //}


        }
    }
}
