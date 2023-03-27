using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _01._Furniture
{
    class Program
    {
       

        static void Main(string[] args)
        {
           
            string strFurniture = Console.ReadLine();

            double spendMoney = 0;

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Purchase")
                {
                    break;
                }
               
                strFurniture += input;

            }
            string pattern = @">>(?<furniture>[A-Za-z]+)<<(\d+\.?\d*)!(\d+)";
            Regex regex = new Regex(pattern);

            MatchCollection matchedFurnitures = regex.Matches(strFurniture);

            foreach (Match furniture in matchedFurnitures)
            {

                spendMoney += double.Parse(furniture.Groups[1].Value) * double.Parse(furniture.Groups[2].Value);


            }

            Console.WriteLine("Bought furniture:");
            foreach (Match furniure in matchedFurnitures)
            {
                Console.WriteLine(furniure.Groups["furniture"]);



            }
            Console.WriteLine($"Total money spend: {spendMoney:f2}");

        }
    }
}
