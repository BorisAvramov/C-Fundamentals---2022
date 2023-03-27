using System;
using System.Linq;
using System.Collections.Generic;

namespace _04._Orders
{
    class Program
    {
        public static object Dictionaty { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<string, double> productPrice = new Dictionary<string, double>(); 
            Dictionary<string, int> productQuantity = new Dictionary<string, int>(); 

            while (true)
            {
                string inpt = Console.ReadLine();
                if (inpt == "buy")
                {
                    break;
                }
                string[] inputArr = inpt.Split().ToArray(); ;
                string productName = inputArr[0];
                double price = double.Parse(inputArr[1]);
                int quantity = int.Parse(inputArr[2]);
                if (!productPrice.ContainsKey(productName))
                {
                    productPrice.Add(productName, price);
                    

                }
                else
                {
                   productPrice[productName] = price;

                }
                if (!productQuantity.ContainsKey(productName))
                {
                    productQuantity.Add(productName, quantity);



                }
                else
                {
                    productQuantity[productName] += quantity;
                }


            }

            foreach (var item in productPrice)
            {
                double totalPrice = item.Value * productQuantity[item.Key];

                Console.WriteLine($"{item.Key} -> {totalPrice:F2}");

            }


        }
    }
}