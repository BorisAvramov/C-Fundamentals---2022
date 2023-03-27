using System;
using System.Linq;

namespace _04._Reverse_Array_of_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();

            Console.WriteLine(string.Join(' ', input.Reverse()));
            //for (int i = input.Length; i > 0; i--)
            //{
            //    Console.Write(input[i-1] + " ");



            //}

            //string[] reversed = new string[input.Length];

            //for (int i = 0; i < input.Length; i++)
            //{
            //    reversed[i] = input[input.Length - 1 - i];
            //}


            ////foreach (var item in reversed)
            ////{
            ////    Console.Write(item + " ");
            ////}

            //Console.WriteLine(string.Join(' ', reversed));

        }
    }
}
