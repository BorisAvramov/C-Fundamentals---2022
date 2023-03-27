using System;

namespace _05._Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());

            GetTotalPrice(product, quantity);

        }

        private static void GetTotalPrice(string product, int quantity)
        {
            double price = GetPrice(product);
            double totalPrice = quantity * price;
            Console.WriteLine($"{totalPrice:f2}");

        }

        private static double GetPrice(string product)
        {
            double price = 0;
            switch (product)
            {
                case "coffee":
                    price = 1.50;
                    break;
                case "water":
                    price = 1.00;
                    break;
                case "coke":
                    price = 1.40;
                    break;
                case "snacks":
                    price = 2.00;
                    break;
                default:
                    break;
            }
            return price;

        }
    }
}
