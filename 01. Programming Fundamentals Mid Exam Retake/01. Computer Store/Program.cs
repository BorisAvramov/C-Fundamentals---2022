using System;

namespace _01._Computer_Store
{
    class Program
    {
        static void Main(string[] args)
        {

            double totalPr = 0;
            double totalPrWithTaxes = 0;
            double taxes = 0;

            string input = Console.ReadLine();

            while (input != "special" && input != "regular")
            {
                
                double pricePart = double.Parse(input);

                if (pricePart <= 0)
                {
                    Console.WriteLine("Invalid price!");
                    
                }
                else
                {
                    totalPr += pricePart;
                }

                input = Console.ReadLine();
            }
            if (totalPr > 0)
            {
                taxes = totalPr * 0.2;
                totalPrWithTaxes = totalPr + taxes;
                if (input == "special")
                {
                    totalPrWithTaxes -= totalPrWithTaxes * 0.1;
                }

                Console.WriteLine($"Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPr:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPrWithTaxes:f2}$");

            }
            else
            {
                Console.WriteLine("Invalid order!");
            }
            
        }
    }
}
