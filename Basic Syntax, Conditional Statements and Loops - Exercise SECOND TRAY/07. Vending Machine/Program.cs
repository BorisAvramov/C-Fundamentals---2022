using System;

namespace _07._Vending_Machine
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double sumCoins = 0;
            double price = 0;

            while (input != "Start")
            {
                double insertedCoins = double.Parse(input);
                switch (insertedCoins)
                {
                    case 0.1:
                    case 0.2:
                    case 0.5:
                    case 1:
                    case 2:
                        sumCoins += insertedCoins;
                        break;
                    default:
                        Console.WriteLine($"Cannot accept {insertedCoins}");
                        break;
                }

                input = Console.ReadLine();
            }
            input = Console.ReadLine();
            while (input != "End")
            {
                switch (input)
                {
                    case "Nuts":
                    case "Water":
                    case "Crisps":
                    case "Soda":
                    case "Coke":
                        if (input == "Nuts")
                        {
                            price = 2.0;
                        }
                        else if (input == "Water")
                        {
                            price = 0.7;
                        }
                        else if (input == "Crisps")
                        {
                            price = 1.5;
                        }
                        else if (input == "Soda")
                        {
                            price = 0.8;
                        }
                        else if (input == "Coke")
                        {
                            price = 1.0;
                        }

                        if (sumCoins < price)
                        {
                            Console.WriteLine("Sorry, not enough money");
                        }
                        else
                        {
                            Console.WriteLine($"Purchased {input.ToLower()}");
                            sumCoins -= price;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"Change: {sumCoins:F2}");

        }
    }
}
