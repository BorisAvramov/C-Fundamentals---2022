using System;
using System.Linq;

namespace _05._Top_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();


            //for (int i = 0; i < arr.Length; i++)
            //{
            //    int counter = 0;

            //    for (int j = i + 1; j < arr.Length; j++)
            //    {

            //        if (arr[i] > arr[j])
            //        {
            //            counter++;
            //        }
            //    }
            //    if (counter == arr.Length - 1 - i)
            //    {
            //        Console.Write(arr[i] + " ");
            //    }


            //}



            for (int i = 0; i < arr.Length; i++)
            {
                bool curIntIsTop = true;
                for (int j = i+1; j < arr.Length; j++)
                {
                   
                     if (arr[i] < arr[j])
                    {
                        curIntIsTop = false;
                        break;
                    }       
                }
                if (curIntIsTop == true)
                {
                    Console.Write(arr[i] + " ");
                }
            }
        }
    }
}
