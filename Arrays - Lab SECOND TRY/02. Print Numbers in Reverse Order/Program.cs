using System;
using System.Linq;

namespace _02._Print_Numbers_in_Reverse_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(string.Join(' ', numbers.Reverse())) ;
            
            //int[] reversedNUm = new int[n];
            //int tempI = 0;

            //for (int i = numbers.Length; i > 0; i--)
            //{
            //    reversedNUm[tempI] = numbers[i-1];
            //    tempI++;
                
            //}

            //foreach (var item in reversedNUm)
            //{
            //    Console.Write(item + " ");
            //}
        }
    }
}
