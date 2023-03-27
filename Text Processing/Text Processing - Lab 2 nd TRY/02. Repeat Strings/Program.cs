using System;
using System.Linq;
using System.Text;

namespace _02._Repeat_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            StringBuilder sbResut = new StringBuilder();

            foreach (var item in input)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    sbResut.Append(item);
                }
            }
            Console.WriteLine(sbResut);
            //for (int i = 0; i < input.Length; i++)
            //{
            //    for (int j = 1; j <= input[i].Length; j++)
            //    {
            //        repeat += input[i];
            //    }

            //}

            //=====================================================

            //foreach (var item in input)
            //{
            //    for (int i = 0; i < item.Length; i++)
            //    {
            //        repeat += item;
            //    }
            //}

            //Console.WriteLine(repeat);

        }
    }
}
