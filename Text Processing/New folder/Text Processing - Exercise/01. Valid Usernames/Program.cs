using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _01._Valid_Usernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ").ToArray();

            Regex.IsMatch(input, @"[A-Za-z0-9_ -]+$");

            //foreach (var item in input)
            //{
            //    bool valid = false;
            //    if (item.Length >= 3 && item.Length <= 16)
            //    {
            //        valid = true;

            //        for (int i = 0; i < item.Length; i++)
            //        {
            //            if (!char.IsDigit(item[i]) && !char.IsLetter(item[i]) && item[i] != '-' && item[i] != '_')
            //            {
            //                valid = false;
            //                break;
            //            }


            //        }
            //    }
               
            //    if (valid)
            //    {
            //        Console.WriteLine(item);
            //    }

            //}

        
        }
    }
}
